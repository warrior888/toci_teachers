using System;
using System.Collections.Generic;
using System.Windows.Forms;
using masterMINDv2.fieldFactory.classes;

namespace masterMINDv2.fieldFactory
{
    public static class FieldFactory
    {
        private static Form _f1;
        public static Dictionary<EnumField, Func<Button>> getField = new Dictionary<EnumField, Func<Button>>
        {
            {EnumField.FieldToClick,()=> new FieldToClick().makeField(_f1)}, 
            {EnumField.CheckField, ()=> new CheckButton().makeField(_f1)},
            {EnumField.StartField, ()=> new FieldToClick().makeField(_f1)},
        };

        public static void makeField(Form2 f1, EnumField whatField)
        {
            _f1 = f1;
            getField[whatField]();
        }
    }
}