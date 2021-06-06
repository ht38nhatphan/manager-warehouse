using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using Guna.UI.WinForms;
namespace test1
{
    class uscontrol
    {
        private GunaButton btnAdd;
        private GunaButton btnEdit;
        private GunaButton btnDelete;
        private GunaButton btnSave;
        private GunaButton btnCancel;


        private BunifuMaterialTextbox[] textBoxes;
        //private ComboBox[] comboBoxes = null;
        //add button 
        public void AddBtnControls(GunaButton btnAdd, GunaButton btnEdit, GunaButton btnDelete, GunaButton btnSave,GunaButton btnCancel)
        {
            this.btnAdd = btnAdd;
            this.btnEdit = btnEdit;
            this.btnDelete = btnDelete;
            this.btnSave = btnSave;
            this.btnCancel = btnCancel;
        }
       
        
        #region setcontrol
        public void setControl(bool isEnable)
        {
            btnAdd.Enabled = isEnable;
            btnEdit.Enabled = isEnable;
            btnDelete.Enabled = isEnable;
            btnSave.Enabled = !isEnable;
            btnCancel.Enabled = !isEnable;
        }
        #endregion
        
        
        
    }
}
