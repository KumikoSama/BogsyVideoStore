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
        public static RegistrationForm RegistrationForm() => FormFactory.CreateForm<RegistrationForm>();
        public static VideoLibrary VideoLibrary() => FormFactory.CreateForm<VideoLibrary>();
        public static CustomerLibrary CustomerLibrary() => FormFactory.CreateForm<CustomerLibrary>();
    }
}
