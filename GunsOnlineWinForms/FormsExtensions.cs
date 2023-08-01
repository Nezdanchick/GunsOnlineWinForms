using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GunsOnlineWinForms
{
    public static class FormsExtensions
    {
        private static readonly Action<Control, ControlStyles, bool> SetStyle = GetActionSetStyle();

        public static void DisableSelect(this Control target) =>
            SetStyle(target, ControlStyles.Selectable, false);

        /// <summary>
        /// Get private element of Control "SetStyle"
        /// </summary>
        /// <returns></returns>
        private static Action<Control, ControlStyles, bool> GetActionSetStyle()
        {
            var method = // get private void SetStyle() from Control
                typeof(Control).GetMethod("SetStyle",
                BindingFlags.NonPublic | BindingFlags.Instance,
                new[] { typeof(ControlStyles), typeof(bool) }
                );

            if (method == null) // do nothing
                return (Control control, ControlStyles style, bool condition) => { };

            var @delegate = // create delegate
            (Action<Control, ControlStyles, bool>)
            Delegate.CreateDelegate(typeof(Action<Control, ControlStyles, bool>),
            method);
            return @delegate;
        }
    }
}
