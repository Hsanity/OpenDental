using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CodeBase;
using OpenDentBusiness;
using WpfControls.UI;

namespace OpenDental {
	public partial class FrmMountItemEdit:FrmODBase {
		public MountItem MountItemCur;
		///<summary>In layout mode, the delete button is available.</summary>
		public bool IsLayout=false;

		public FrmMountItemEdit() {
			InitializeComponent();
			Load+=FrmMountItemEdit_Load;
			PreviewKeyDown+=FrmMountItemEdit_PreviewKeyDown;
		}

		private void FrmMountItemEdit_Load(object sender, EventArgs e){
			Lang.F(this);
			if(!IsLayout){
				butDelete.Visible=false;
			}
			textXpos.Text=MountItemCur.Xpos.ToString();
			textYpos.Text=MountItemCur.Ypos.ToString();
			textWidth.Text=MountItemCur.Width.ToString();
			textHeight.Text=MountItemCur.Height.ToString();
			textRotate.Value=MountItemCur.RotateOnAcquire;
			textToothNumbers.Text=Tooth.DisplayRange(MountItemCur.ToothNumbers);
			textTextShowing.Text=MountItemCur.TextShowing;
			textFontSize.Value=MountItemCur.FontSize;
		}

		private void butAddField_Click(object sender,EventArgs e) {
			List<MessageReplaceType> listMessageReplaceTypes=new List<MessageReplaceType>();
			listMessageReplaceTypes.Add(MessageReplaceType.Office);
			listMessageReplaceTypes.Add(MessageReplaceType.Patient);
			listMessageReplaceTypes.Add(MessageReplaceType.Mount);
			FrmMessageReplacements frmMessageReplacements=new FrmMessageReplacements(listMessageReplaceTypes);
			frmMessageReplacements.MessageReplacementSystemType=MessageReplacementSystemType.Mount;
			frmMessageReplacements.IsSelectionMode=true;
			frmMessageReplacements.ShowDialog();
			if(frmMessageReplacements.IsDialogOK) {
				textTextShowing.SelectedText=frmMessageReplacements.ReplacementTextSelected;
			}
		}

		private void butDelete_Click(object sender, EventArgs e){
			if(MountItemCur.IsNew){//although not currenly used
				IsDialogCancel=true;
				return;
			}
			if(!MsgBox.Show(this,MsgBoxButtons.OKCancel,"Delete?")){
				return;
			}
			try{
				MountItems.Delete(MountItemCur);
			}
			catch(Exception ex){
				MsgBox.Show(ex.Message);
				return;
			}
			IsDialogOK=true;
		}

		private void FrmMountItemEdit_PreviewKeyDown(object sender,KeyEventArgs e) {
			if(butSave.IsAltKey(Key.S,e)) {
				butSave_Click(this,new EventArgs());
			}
		}

		private void butSave_Click(object sender,EventArgs e) {
			if(!textXpos.IsValid()
				|| !textYpos.IsValid()
				|| !textWidth.IsValid()
				|| !textHeight.IsValid()
				|| !textRotate.IsValid()
				|| !textFontSize.IsValid())
			{
				MsgBox.Show(this,"Please fix data entry errors first.");
				return;
			}
			if(!textRotate.Value.In(0,90,180,270)){
				MsgBox.Show(this,"Rotate value invalid.");
				return;
			}
			if(!textTextShowing.Text.IsNullOrEmpty() && textFontSize.Value==0){
				MsgBox.Show(this,"Please enter a font size.");
				return;
			}
			try{
				MountItemCur.ToothNumbers=Tooth.ParseRange(textToothNumbers.Text);
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
				return;
			}
			MountItemCur.Xpos=PIn.Int(textXpos.Text);
			MountItemCur.Ypos=PIn.Int(textYpos.Text);
			MountItemCur.Width=PIn.Int(textWidth.Text);
			MountItemCur.Height=PIn.Int(textHeight.Text);
			MountItemCur.RotateOnAcquire=textRotate.Value;
			MountItemCur.TextShowing=textTextShowing.Text;
			MountItemCur.FontSize=(float)textFontSize.Value;
			if(MountItemCur.IsNew){
				MountItems.Insert(MountItemCur);
			}
			else{
				MountItems.Update(MountItemCur);
			}
			IsDialogOK=true;
		}

	}
}