using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Newtonsoft.Json;
using OpenDentBusiness;
using WpfControls.UI;

namespace OpenDental {
/*
This Frm gets a lot of inspiration from FormSheetDefEdit.
Like in that form, edits to the fields do not get saved to the db as they are edited, but instead get saved when closing this Frm.
*/
	///<summary></summary>
	public partial class FrmEFormDefEdit : FrmODBase {
		///<summary>This is the object we are editing. After load, the list of attached EFormFieldDefs must be ignored. Instead, refer to CtrlEFormFill.ListEFormFields.</summary>
		public EFormDef EFormDefCur;
		private bool _isLoaded;
		private ContextMenu contextMenu;
		private DispatcherTimer _dispatcherTimer;
		///<summary>This contains all the EFormFields that were deleted during this session, but only if they were originally part of the eForm. Any field that was created in this session and then deleted does not get included here. Those get truly deleted when user clicks Delete within each field edit window. This list is public because the parent form does all the actual deletions.</summary>
		public List<long> ListEFormFieldDefNumsToDelete;
		///<summary>After closing this form, this tracks whether user clicked delete.</summary>
		public bool IsDeleted;
		 ///<summary>We don't fire off a signal to update the language cache on other computers until we hit Save in this window. So each edit window has a variable to keep track of whether there are any new translations. That bubbles up to this variable.</summary>
		private bool _isChangedLanCache;

		#region Constructor
		///<summary></summary>
		public FrmEFormDefEdit() {
			InitializeComponent();
			Load+=FrmEFormDefEdit_Load;
			PreviewKeyDown+=FrmEFormDefEdit_PreviewKeyDown;
			SizeChanged+=FrmEFormDefEdit_SizeChanged;
			FormClosed+=FrmEFormDefEdit_FormClosed;
			//gridMain.CellDoubleClick+=gridMain_CellDoubleClick;
			ctrlEFormFill.IsSetupMode=true;
			ctrlEFormFill.EventDoubleClickField+=CtrlEFormFill_EventDoubleClickField;
			textVIntMaxWidth.TextChanged+=TextVIntMaxWidth_TextChanged;
			_dispatcherTimer=new DispatcherTimer();
			_dispatcherTimer.Interval=TimeSpan.FromMilliseconds(500);
			_dispatcherTimer.Tick+=_dispatcherTimer_Tick;
		}
		#endregion Constructor

		#region Methods - private Event Handlers
		private void _dispatcherTimer_Tick(object sender,EventArgs e) {
			SetCtrlWidth();
			_dispatcherTimer.Stop();
		}

		///<summary></summary>
		private void ComboLanguage_SelectionChangeCommitted(object sender,EventArgs e) {
			if(comboLanguage.SelectedIndex==0){
				ctrlEFormFill.LanguageShowing="";
			}
			else{
				ctrlEFormFill.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			ctrlEFormFill.RefreshLayout();//This will now have the new translations
		}

		///<summary></summary>
		private void CtrlEFormFill_EventDoubleClickField(object sender,int idx) {
			bool isPreviousStackable=false;
			if(idx>0 && EFormFieldDefs.IsHorizStackableType(ctrlEFormFill.ListEFormFields[idx-1].FieldType)){
				isPreviousStackable=true;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.TextField){
				FrmEFormTextBoxEdit frmEFormTextBoxEdit=new FrmEFormTextBoxEdit();
				frmEFormTextBoxEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormTextBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormTextBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormTextBoxEdit.ShowDialog();
				_isChangedLanCache|=frmEFormTextBoxEdit.IsChangedLanCache;
				if(frmEFormTextBoxEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						//Immediately delete from db
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//also deletes languagepats.
					}
					else{
						//Mark it for later deletion. Don't delete yet because user might cancel out of this form window.
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					//Whether new field or existing field, remove it from the list
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				//Whether saved or deleted, we need to refresh the layout
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.Label){
				//see comments in FieldType==EnumEFormFieldType.TextField
				FrmEFormLabelEdit frmEFormLabelEdit=new FrmEFormLabelEdit();
				frmEFormLabelEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormLabelEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormLabelEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormLabelEdit.ShowDialog();
				_isChangedLanCache|=frmEFormLabelEdit.IsChangedLanCache;
				if(frmEFormLabelEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);
					}
					else{
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.DateField){
				//see comments in FieldType==EnumEFormFieldType.TextField
				FrmEFormDateFieldEdit frmEFormDateFieldEdit=new FrmEFormDateFieldEdit();
				frmEFormDateFieldEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormDateFieldEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormDateFieldEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormDateFieldEdit.ShowDialog();
				_isChangedLanCache|=frmEFormDateFieldEdit.IsChangedLanCache;
				if(frmEFormDateFieldEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);
					}
					else{
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.CheckBox){
				FrmEFormCheckBoxEdit frmEFormCheckBoxEdit=new FrmEFormCheckBoxEdit();
				frmEFormCheckBoxEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormCheckBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormCheckBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormCheckBoxEdit.ShowDialog();
				_isChangedLanCache|=frmEFormCheckBoxEdit.IsChangedLanCache;
				if(frmEFormCheckBoxEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						//Immediately delete from db
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//also deletes languagepats.
					}
					else{
						//Mark it for later deletion. Don't delete yet because user might cancel out of this form window.
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					//Whether new field or existing field, remove it from the list
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				//Whether saved or deleted, we need to refresh the layout
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.RadioButtons){
				//see comments in FieldType==EnumEFormFieldType.TextField
				FrmEFormRadioButtonsEdit frmEFormRadioButtonsEdit=new FrmEFormRadioButtonsEdit();
				frmEFormRadioButtonsEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormRadioButtonsEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormRadioButtonsEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormRadioButtonsEdit.ShowDialog();
				_isChangedLanCache|=frmEFormRadioButtonsEdit.IsChangedLanCache;
				if(frmEFormRadioButtonsEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);
					}
					else{
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.SigBox){
				//see comments in FieldType==EnumEFormFieldType.TextField
				FrmEFormSigBoxEdit frmEFormSigBoxEdit=new FrmEFormSigBoxEdit();
				frmEFormSigBoxEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormSigBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
				if(comboLanguage.SelectedIndex>0){
					frmEFormSigBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
				}
				frmEFormSigBoxEdit.ShowDialog();
				_isChangedLanCache|=frmEFormSigBoxEdit.IsChangedLanCache;
				if(frmEFormSigBoxEdit.IsDialogCancel){
					return;
				}
				if(ctrlEFormFill.ListEFormFields[idx].IsDeleted){
					if(ctrlEFormFill.ListEFormFields[idx].IsNew){//the field was added in this session previously
						EFormFieldDefs.Delete(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//also deletes languagepats.
					}
					else{
						ListEFormFieldDefNumsToDelete.Add(ctrlEFormFill.ListEFormFields[idx].EFormFieldDefNum);//these will get deleted when user clicks Save
					}
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
				}
				ctrlEFormFill.RefreshLayout();
				return;
			}
			if(ctrlEFormFill.ListEFormFields[idx].FieldType==EnumEFormFieldType.MedicationList){
				FrmEFormMedicationListEdit frmEFormMedicationListEdit=new FrmEFormMedicationListEdit();
				frmEFormMedicationListEdit.EFormFieldCur=ctrlEFormFill.ListEFormFields[idx];
				frmEFormMedicationListEdit._listEFormFields=ctrlEFormFill.ListEFormFields;
				frmEFormMedicationListEdit.EFormDefCur=EFormDefCur;
				frmEFormMedicationListEdit.ShowDialog();
				if(frmEFormMedicationListEdit.IsDialogCancel){
					return;
				}
				if(frmEFormMedicationListEdit.EFormFieldCur==null){
					ctrlEFormFill.ListEFormFields.RemoveAt(idx);
					ctrlEFormFill.RefreshLayout();
					return;
				}
			}
			ctrlEFormFill.RefreshLayout();
			return;
		}

		private void FrmEFormDefEdit_FormClosed(object sender,EventArgs e) {
			for(int i=0;i<EFormDefCur.ListEFormFieldDefs.Count;i++){
				if(EFormDefCur.ListEFormFieldDefs[i].FieldType==EnumEFormFieldType.RadioButtons){
					EFormField eFormField=EFormFields.FromDef(EFormDefCur.ListEFormFieldDefs[i]);
					LanguagePats.SyncRadioButtonTranslations(eFormField);//Ensures translations match up with PickListVis for RadioButtons, whether users save or cancel out of the window.
				}
			}
			if(_isChangedLanCache){
				DataValid.SetInvalid(InvalidType.Languages);
			}
		}

		///<summary></summary>
		private void FrmEFormDefEdit_Load(object sender, EventArgs e) {
			Lang.F(this);
			ctrlEFormFill.ListEFormFields=EFormFields.FromListDefs(EFormDefCur.ListEFormFieldDefs);
			ctrlEFormFill.RefreshLayout();
			textDescription.Text=EFormDefCur.Description;
			comboType.Items.AddEnums<EnumEFormType>();
			comboType.SetSelectedEnum(EFormDefCur.FormType);
			contextMenu=new ContextMenu(this);
			WpfControls.EFormL.FillComboLanguage(comboLanguage);
			labelLanguage.Visibility=comboLanguage.Visibility;//hide them both if no patient languages set up
			comboLanguage.SelectionChangeCommitted+=ComboLanguage_SelectionChangeCommitted;
			//gridMain.ContextMenu=contextMenu;
			//contextMenu.Add(new MenuItem("Delete",menuDelete_Click));
			if(!EFormDefCur.IsInternal) {
				labelTitle.Text="This is a custom eForm, not internal.";
			}
			_isLoaded=true;
			textVIntMaxWidth.Value=EFormDefCur.MaxWidth;//this triggers SetCtrlWidth
			ListEFormFieldDefNumsToDelete=new List<long>();
		}

		private void FrmEFormDefEdit_PreviewKeyDown(object sender,KeyEventArgs e) {
			if(Keyboard.Modifiers!=ModifierKeys.Control) {
				return;
			}
			if(e.Key==Key.X){
				butCut_Click(this,new EventArgs());
			}
			if(e.Key==Key.C){
				butCopy_Click(this,new EventArgs());
			}
			if(e.Key==Key.V){
				butPaste_Click(this,new EventArgs());
			}
		}

		private void FrmEFormDefEdit_SizeChanged(object sender,SizeChangedEventArgs e) {
			//if(!_isLoaded){
			//	return;
			//}
			//ctrlEFormFill.RefreshLayout();
			SetCtrlWidth();
		}

		private void TextVIntMaxWidth_TextChanged(object sender,EventArgs e) {
			if(_dispatcherTimer.IsEnabled){
				_dispatcherTimer.Stop();
			}
			_dispatcherTimer.Start();
		}
		#endregion Methods - private Event Handlers

		#region Methods - private Event Handlers, Add buttons
		private void butTextField_Click(object sender,EventArgs e) {
			//we must insert an eFormFieldDef in order to have a PK for languages.
			//It can be completely empty except for the PK. Nothing else matters.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormTextBoxEdit frmEFormTextBoxEdit=new FrmEFormTextBoxEdit();
			eFormField.IsNew=true;
			//The reason for setting IsNew is so that if user does click Save here, they might still edit this same field later.
			//If they click delete at that time, then we must handle that properly by completely deleting it instead of just marking it for later deletion.
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.TextField;
			frmEFormTextBoxEdit.EFormFieldCur=eFormField;
			frmEFormTextBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
				//guaranteed to not be -1
			}
			//We will actually add it to the list.
			//So any new field will be in the db and in the list prior to launching edit window
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormTextBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormTextBoxEdit.ShowDialog();
			_isChangedLanCache|=frmEFormTextBoxEdit.IsChangedLanCache;
			if(frmEFormTextBoxEdit.IsDialogCancel || eFormField.IsDeleted){
				//They either clicked Cancel or Delete.
				//Both actions are identical for a new field.
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);//also deletes languagepats.
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			//deprecated: AddNewField(eFormField);
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butLabel_Click(object sender,EventArgs e) {
			//See comments in butTextField_Click.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormLabelEdit frmEFormLabelEdit=new FrmEFormLabelEdit();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.Label;
			frmEFormLabelEdit.EFormFieldCur=eFormField;
			frmEFormLabelEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormLabelEdit.EFormDefCur=EFormDefCur;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
			}
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormLabelEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormLabelEdit.ShowDialog();
			_isChangedLanCache|=frmEFormLabelEdit.IsChangedLanCache;
			if(frmEFormLabelEdit.IsDialogCancel || eFormField.IsDeleted){
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butDateField_Click(object sender,EventArgs e) {
			//See comments in butTextField_Click.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormDateFieldEdit frmEFormDateFieldEdit=new FrmEFormDateFieldEdit();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.DateField;
			frmEFormDateFieldEdit.EFormFieldCur=eFormField;
			frmEFormDateFieldEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormDateFieldEdit.EFormDefCur=EFormDefCur;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
			}
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormDateFieldEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormDateFieldEdit.ShowDialog();
			_isChangedLanCache|=frmEFormDateFieldEdit.IsChangedLanCache;
			if(frmEFormDateFieldEdit.IsDialogCancel || eFormField.IsDeleted){
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butCheckBox_Click(object sender,EventArgs e) {
			//See comments in butTextField_Click.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormCheckBoxEdit frmEFormCheckBoxEdit=new FrmEFormCheckBoxEdit();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.CheckBox;
			frmEFormCheckBoxEdit.EFormFieldCur=eFormField;
			frmEFormCheckBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormCheckBoxEdit.EFormDefCur=EFormDefCur;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
			}
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormCheckBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormCheckBoxEdit.ShowDialog();
			_isChangedLanCache|=frmEFormCheckBoxEdit.IsChangedLanCache;
			if(frmEFormCheckBoxEdit.IsDialogCancel || eFormField.IsDeleted){
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butRadioButtons_Click(object sender,EventArgs e) {
			//See comments in butTextField_Click.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormRadioButtonsEdit frmEFormRadioButtonsEdit=new FrmEFormRadioButtonsEdit();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.RadioButtons;
			frmEFormRadioButtonsEdit.EFormFieldCur=eFormField;
			frmEFormRadioButtonsEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
			}
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormRadioButtonsEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormRadioButtonsEdit.ShowDialog();
			_isChangedLanCache|=frmEFormRadioButtonsEdit.IsChangedLanCache;
			if(frmEFormRadioButtonsEdit.IsDialogCancel || eFormField.IsDeleted){
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butSigBox_Click(object sender,EventArgs e) {
			//See comments in butTextField_Click.
			EFormFieldDef eFormFieldDef=new EFormFieldDef();
			EFormFieldDefs.Insert(eFormFieldDef);
			EFormField eFormField=EFormFields.FromDef(eFormFieldDef);
			FrmEFormSigBoxEdit frmEFormSigBoxEdit=new FrmEFormSigBoxEdit();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.SigBox;
			eFormField.ValueLabel="Signature";
			frmEFormSigBoxEdit.EFormFieldCur=eFormField;
			frmEFormSigBoxEdit.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormSigBoxEdit.EFormDefCur=EFormDefCur;
			int idxNew=ctrlEFormFill.GetSelectedIndex();
			if(idxNew==-1){
				idxNew=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
			}
			ctrlEFormFill.ListEFormFields.Insert(idxNew,eFormField);
			if(comboLanguage.SelectedIndex>0){
				frmEFormSigBoxEdit.LanguageShowing=comboLanguage.SelectedItem.ToString();
			}
			frmEFormSigBoxEdit.ShowDialog();
			_isChangedLanCache|=frmEFormSigBoxEdit.IsChangedLanCache;
			if(frmEFormSigBoxEdit.IsDialogCancel || eFormField.IsDeleted){
				EFormFieldDefs.Delete(eFormField.EFormFieldDefNum);
				ctrlEFormFill.ListEFormFields.Remove(eFormField);
				return;
			}
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idxNew);
		}

		private void butMedicationList_Click(object sender,EventArgs e) {
			FrmEFormMedicationListEdit frmEFormMedicationListEdit=new FrmEFormMedicationListEdit();
			EFormField eFormField=new EFormField();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.MedicationList;
			EFormMedListLayout eFormMedListLayout=new EFormMedListLayout();
			eFormField.ValueLabel=JsonConvert.SerializeObject(eFormMedListLayout);
			frmEFormMedicationListEdit.EFormFieldCur=eFormField;
			frmEFormMedicationListEdit._listEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormMedicationListEdit.EFormDefCur=EFormDefCur;
			frmEFormMedicationListEdit.ShowDialog();
			if(frmEFormMedicationListEdit.IsDialogCancel){
				return;
			}
			if(frmEFormMedicationListEdit.EFormFieldCur==null){
				//they clicked Delete for some reason, which is the same as cancel.
				return;
			}
			AddNewField(eFormField);//This will refresh the layout and set a selected field.
		}

		private void butPageBreak_Click(object sender,EventArgs e) {
			if(ctrlEFormFill.ListEFormFields.Count==0) {//Don't allow a page break to be the first item in the grid.
				MsgBox.Show(this,"Cannot add a page break before adding fields first.");
				return;
			}
			EFormField eFormField =new EFormField();
			eFormField.IsNew=true;
			eFormField.FontScale=100;
			eFormField.FieldType=EnumEFormFieldType.PageBreak;
			AddNewField(eFormField);//This will refresh the layout and set a selected field.
		}
		#endregion Methods - private Event Handlers, Add buttons

		#region Methods - private Event Handlers, other buttons
		///<summary></summary>
		private void butDelete_Click(object sender,EventArgs e) {
			if(!MsgBox.Show(this,MsgBoxButtons.OKCancel,"Delete entire form?")){
				return;
			}
			//The form deletion actually happens in the parent.
			//Delete of a new form is equivalent to cancel, and both of those happen in the parent.
			//Delete of an existing form is also handled in the parent.
			//Any fields that were added in this session and then deleted are already handled and gone.
			//Any fields that were originally part of the eFormDef are still present and will be handled in the parent.
			IsDeleted=true;
			IsDialogOK=true;
		}

		private void butSave_Click(object sender,EventArgs e) {
			if(string.IsNullOrEmpty(EFormDefCur.Description)){
				MsgBox.Show(this,"Description is required");
				return;
			}
			for(int i=0;i<ctrlEFormFill.ListEFormFields.Count-1;i++){//the -1 here allows comparing i+1
				if(ctrlEFormFill.ListEFormFields[i].FieldType==EnumEFormFieldType.PageBreak 
					&& ctrlEFormFill.ListEFormFields[i+1].FieldType==EnumEFormFieldType.PageBreak)
				{
					MsgBox.Show(this,"Cannot have two page breaks back to back.");
				}
			}
			//End of validation
			EFormDefCur.Description=textDescription.Text;
			EFormDefCur.FormType=comboType.GetSelected<EnumEFormType>();
			int maxWidth=450;
			if(textVIntMaxWidth.IsValid()){//instead of telling user about this, we will just ignore errors
				maxWidth=textVIntMaxWidth.Value;
				if(maxWidth<50){
					maxWidth=50;
				}
				if(maxWidth>1000){
					maxWidth=1000;
				}
			}
			EFormDefCur.MaxWidth=maxWidth;
			//All database changes actually happen in the parent form.
			//Even all the fields that were marked for deletion in ListEFormFieldDefNumsToDelete
			//We must convert all the EFormFields back into their corresponding EFormFieldDefs, properly attached to the EFormDef
			//so that the parent can take appropriate action.
			EFormDefCur.ListEFormFieldDefs.Clear();
			for(int i = 0;i<ctrlEFormFill.ListEFormFields.Count;i++) {
				EFormFieldDef eFormFieldDef = EFormFields.ToDef(ctrlEFormFill.ListEFormFields[i]);//this also handles the PK
				eFormFieldDef.EFormDefNum=EFormDefCur.EFormDefNum;//this won't change in the db
				eFormFieldDef.ItemOrder=i;//only place where this is fixed
				//EFormFieldDefs.Update(eFormFieldDef);//this happens in parent
				EFormDefCur.ListEFormFieldDefs.Add(eFormFieldDef);
			}
			IsDialogOK=true;
		}

		private void butCut_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=ctrlEFormFill.GetSelectedIndices();
			if(listSelectedIndices.Count==0) {
				MsgBox.Show(this,"Please select at least 1 field.");
				return;
			}
			List<EFormField> listEFormFields=new List<EFormField>();
			for(int i=0;i<listSelectedIndices.Count;i++){
				EFormField eFormField=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].Copy();
				eFormField.TagOD=null;
				//none of this actually matters because when this form is saved, these fields get reset anyway
				eFormField.EFormFieldNum=0;
				eFormField.EFormNum=0;
				eFormField.ItemOrder=0;
				listEFormFields.Add(eFormField);
			}
			string str=JsonConvert.SerializeObject(listEFormFields);
			DataObject dataObject=new DataObject();
			dataObject.SetData("ListEFormFields",str);
			try{
				Clipboard.SetDataObject(dataObject);
			}
			catch(Exception ex){
				MsgBox.Show("Failed: "+ex.Message);
			}
			Cursor=Cursors.Wait;
			ctrlEFormFill.Cursor=Cursors.Wait;
			for(int i=listSelectedIndices.Count-1;i>=0;i--){//backward because removing
				ctrlEFormFill.ListEFormFields.RemoveAt(listSelectedIndices[i]);
			}
			ctrlEFormFill.RefreshLayout();
			//System.Threading.Thread.Sleep(200);//No need. They get feedback by seeing their fields disappear
			Cursor=Cursors.Arrow;
			ctrlEFormFill.Cursor=Cursors.Arrow;
		}

		private void butCopy_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=ctrlEFormFill.GetSelectedIndices();
			if(listSelectedIndices.Count==0) {
				MsgBox.Show(this,"Please select at least 1 field.");
				return;
			}
			List<EFormField> listEFormFields=new List<EFormField>();
			for(int i=0;i<listSelectedIndices.Count;i++){
				EFormField eFormField=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].Copy();
				eFormField.TagOD=null;
				//none of this actually matters because when this field is pasted these get reset anyway
				eFormField.EFormFieldNum=0;
				eFormField.EFormFieldDefNum=0;
				eFormField.EFormNum=0;
				eFormField.ItemOrder=0;
				listEFormFields.Add(eFormField);
			}
			string str=JsonConvert.SerializeObject(listEFormFields);
			DataObject dataObject=new DataObject();
			dataObject.SetData("ListEFormFields",str);
			try{
				Clipboard.SetDataObject(dataObject);
			}
			catch(Exception ex){
				MsgBox.Show("Failed: "+ex.Message);
			}
			Cursor=Cursors.Wait;
			ctrlEFormFill.Cursor=Cursors.Wait;
			System.Threading.Thread.Sleep(200);//so that the wait cursor will flash to give feedback
			Cursor=Cursors.Arrow;
			ctrlEFormFill.Cursor=Cursors.Arrow;
		}

		private void butPaste_Click(object sender,EventArgs e) {
			IDataObject iDataObject=null;
			try {
				iDataObject=Clipboard.GetDataObject();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
				return;
			}
			if(iDataObject==null){
				MsgBox.Show(this,"Clipboard is empty.");
				return;
			}
			string str=(string)iDataObject.GetData("ListEFormFields");
			if(str is null){
				MsgBox.Show(this,"There are no eForm Fields on the Clipboard.");
				return;
			}
			List<EFormField> listEFormFields=JsonConvert.DeserializeObject<List<EFormField>>(str);
			for(int i=0;i<listEFormFields.Count;i++){
				//we must insert an eFormFieldDef in order to have a PK for languages.
				//It can be completely empty except for the PK. Nothing else matters.
				EFormFieldDef eFormFieldDef=new EFormFieldDef();
				EFormFieldDefs.Insert(eFormFieldDef);
				listEFormFields[i].EFormFieldDefNum=eFormFieldDef.EFormFieldDefNum;
				listEFormFields[i].IsNew=true;
			}
			int idx=ctrlEFormFill.GetSelectedIndex();
			if(idx==-1){
				idx=EFormFields.GetLastIdxThisPage(ctrlEFormFill.ListEFormFields,ctrlEFormFill.GetPageShowing());
				//guaranteed to not be -1
			}
			ctrlEFormFill.ListEFormFields.InsertRange(idx,listEFormFields);
			ctrlEFormFill.RefreshLayout();//This also fixes all stacking
			//set the new fields selected
			for(int i=0;i<listEFormFields.Count;i++){
				ctrlEFormFill.SetSelected(idx+i);
			}
		}

		///<summary></summary>
		private void butSetCondition_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=ctrlEFormFill.GetSelectedIndices();
			if(listSelectedIndices.Count==0) {
				MsgBox.Show(this,"This is used to set the decision on selected fields. Please select at least 1 field.");
				return;
			}
			FrmEFormFieldPicker frmEFormFieldPicker=new FrmEFormFieldPicker();
			frmEFormFieldPicker.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormFieldPicker.IsMultiple=true;
			frmEFormFieldPicker.ListSelectedIndices=listSelectedIndices;
			frmEFormFieldPicker.ShowDialog();
			if(frmEFormFieldPicker.IsDialogCancel){
				return;
			}
			for(int i=0;i<listSelectedIndices.Count;i++) {
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].ConditionalParent=frmEFormFieldPicker.ParentSelected;
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].ConditionalValue=frmEFormFieldPicker.ValueSelected;
			}
			ctrlEFormFill.RefreshLayout();
		}

		///<summary></summary>
		private void butSetPageCondition_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=new List<int>();
			//Get all of the field indices on the currently viewed page.
			for(int i=0;i<ctrlEFormFill.ListEFormFields.Count;i++) {
				if(ctrlEFormFill.ListEFormFields[i].FieldType==EnumEFormFieldType.PageBreak) {
					continue;
				}
				if(ctrlEFormFill.ListEFormFields[i].Page==ctrlEFormFill.GetPageShowing()) {
					listSelectedIndices.Add(i);
				}
			}
			FrmEFormFieldPicker frmEFormFieldPicker=new FrmEFormFieldPicker();
			frmEFormFieldPicker.ListEFormFields=ctrlEFormFill.ListEFormFields;
			frmEFormFieldPicker.IsMultiple=true;
			frmEFormFieldPicker.ListSelectedIndices=listSelectedIndices;
			frmEFormFieldPicker.ShowDialog();
			if(frmEFormFieldPicker.IsDialogCancel) {
				return;
			}
			for(int i=0;i<listSelectedIndices.Count;i++) {
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].ConditionalParent=frmEFormFieldPicker.ParentSelected;
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]].ConditionalValue=frmEFormFieldPicker.ValueSelected;
			}
			ctrlEFormFill.RefreshLayout();
		}

		/*
		///<summary></summary>
		private void butUp_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=ctrlEFormFill.GetSelectedIndices();
			if(listSelectedIndices.Count==0) {
				MsgBox.Show(this,"Please select a row first.");
				return;
			}
			if(listSelectedIndices.Contains(0)) {
				return;
			}
			for(int i=0;i<listSelectedIndices.Count;i++) { 
				EFormField eFormFieldAbove=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]-1];
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]-1]=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]];
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]]=eFormFieldAbove;
			}
			ctrlEFormFill.RefreshLayout();
			for(int i=0;i<listSelectedIndices.Count;i++) { 
				ctrlEFormFill.SetSelected(listSelectedIndices[i]-1);
			}
		}

		///<summary></summary>
		private void butDown_Click(object sender,EventArgs e) {
			List<int> listSelectedIndices=ctrlEFormFill.GetSelectedIndices();
			listSelectedIndices.Reverse();//Reverse the list so that we start with the lowest GridRow.
			if(listSelectedIndices.Count==0) {
				MsgBox.Show(this,"Please select a row first.");
				return;
			}
			if(listSelectedIndices.Contains(ctrlEFormFill.ListEFormFields.Count-1)) {
				return;
			}
			for(int i=0;i<listSelectedIndices.Count;i++) {
				EFormField eFormFieldBelow=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]+1];
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]+1]=ctrlEFormFill.ListEFormFields[listSelectedIndices[i]];
				ctrlEFormFill.ListEFormFields[listSelectedIndices[i]]=eFormFieldBelow;
			}
			ctrlEFormFill.RefreshLayout();
			for(int i=0;i<listSelectedIndices.Count;i++) { 
				ctrlEFormFill.SetSelected(listSelectedIndices[i]+1);
			}
		}*/
		#endregion Methods - private Event Handlers, other buttons

		#region Methods - private
		private void AddNewField(EFormField eFormField) {
			//This is getting deprecated. Fields will be added prior to showing their dialog.
			if(ctrlEFormFill.ListEFormFields.Count==0) {//This handles when the form is empty and adding the first field.
				ctrlEFormFill.ListEFormFields.Add(eFormField);
				ctrlEFormFill.RefreshLayout();
				return;
			}
			int idx=ctrlEFormFill.GetSelectedIndex();
			int pageShowing=ctrlEFormFill.GetPageShowing();//Will never be 0 because 1-based.
			if(idx>=0 && ctrlEFormFill.ListEFormFields[idx].Page!=pageShowing){//idx may be -1 before hitting this line if no index is selected when adding new field.
				idx=-1;//we don't want to insert at that idx because it's on another page.
			}
			if(idx==-1){
				//Set the idx value to the end of the current page showing.
				int numberOfPageBreaks=0;
				for(int i=0;i<ctrlEFormFill.ListEFormFields.Count;i++) {
					if(ctrlEFormFill.ListEFormFields[i].FieldType==EnumEFormFieldType.PageBreak) {
						numberOfPageBreaks++;
					}
					if(numberOfPageBreaks==pageShowing) {
						idx=i;//the page break at the bottom of the page we are on.
						break;
					}
				}
				if(idx==-1) {//Still -1. This is because we are looking at the last page.
					idx=ctrlEFormFill.ListEFormFields.Count-1;
				}
			}
			ctrlEFormFill.ListEFormFields.Insert(idx,eFormField);
			ctrlEFormFill.RefreshLayout();
			ctrlEFormFill.SetSelected(idx);
		}

		private void SetCtrlWidth(){
			if(!_isLoaded){
				return;
			}
			int maxVal=450;
			if(textVIntMaxWidth.IsValid() && textVIntMaxWidth.Value!=0){
				maxVal=textVIntMaxWidth.Value;
				if(maxVal<50){
					maxVal=50;
				}
				if(maxVal>1000){
					maxVal=1000;
				}
			}
			int avail=(int)ActualWidth-(int)ctrlEFormFill.Margin.Left-30;
			if(maxVal>avail){
				maxVal=avail;
			}
			ctrlEFormFill.Width=maxVal;
			ctrlEFormFill.UpdateLayout();
			ctrlEFormFill.RefreshLayout();
		}
		#endregion Methods - private
	}
}