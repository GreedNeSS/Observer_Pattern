using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public delegate void UpdateStatus(string name, string status);

    internal class User
    {
        public string Name { get; set; }
        public string Status { get; private set; }

        public event UpdateStatus? OnUpdateStatus;

        public User(string name, string status)
        {
            Name = name;
            Status = status;
        }

        public void SetStatus(string status)
        {
            Status = status;
            OnUpdateStatus?.Invoke(Name, Status);
        }
    }
}
