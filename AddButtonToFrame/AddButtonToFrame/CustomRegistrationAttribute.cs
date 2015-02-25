using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;

namespace Company.AddButtonToFrame
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class CustomRegistrationAttribute : RegistrationAttribute
    {
        public override void Register(RegistrationContext context)
        {
            Key packkageKey = null;
            try
            {
                packkageKey = context.CreateKey(@"MainWindowFrameControls\{" + GuidList.guidBadgeString + "}");
                packkageKey.SetValue("@", "Badge");
                packkageKey.SetValue("Alignment", "TitleBarRight");
                packkageKey.SetValue("DisplayName", "#1007");
                packkageKey.SetValue("FullScreenAlignment", "MenuBarRight");
                packkageKey.SetValue("FullScreenSort", 0x32);
                packkageKey.SetValue("Package", GuidList.guidAddButtonToFramePkgString);
                packkageKey.SetValue("Sort", 0x32);
                packkageKey.SetValue("ViewFactory", GuidList.guidUIFactoryString);
                packkageKey.SetValue("ViewId", 0x64);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public override void Unregister(RegistrationContext context)
        {
            context.RemoveKey(@"Packages\" + context.ComponentType.GUID + @"}\Custom");
        }
    }
}
