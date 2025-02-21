using BogsyVideoStore.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Classes
{
    public class FormFactory
    {
        public static T CreateForm<T>() where T : new()
        {
            return new T();
        }
    }

    public static class FormsHandler
    {
        public static Dashboard Dashboard() => FormFactory.CreateForm<Dashboard>();
    }
}
