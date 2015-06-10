using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace TheClubExtendedComponent
{
    [ProvideProperty("Obrigatorio", typeof(Control))]
    public class Obrigatorio : Component, IExtenderProvider
    {
        private class Properties
        {
            public bool Obrigatorio;

            public Properties()
            {
                Obrigatorio = false;
            }
        }

        private Hashtable properties;

        private Properties EnsurePropertiesExists(object key)
        {
            Properties p = (Properties)properties[key];
            if (p == null)
            {
                p = new Properties();
                properties[key] = p;
            }

            return p;
        }

        public Obrigatorio()
        {
            properties = new Hashtable();
        }

        public Obrigatorio(IContainer container)
        {
            container.Add(this);
            properties = new Hashtable();
        }

        public void SetObrigatorio(Control lControl, bool bValue)
        {
            EnsurePropertiesExists(lControl).Obrigatorio = bValue;
        }

        public bool GetObrigatorio(Control lControl)
        {
            return EnsurePropertiesExists(lControl).Obrigatorio;
        }

        bool IExtenderProvider.CanExtend(object lControl)
        {
            return (lControl is Control);
        }
    }
}