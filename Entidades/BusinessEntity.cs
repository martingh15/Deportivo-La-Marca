using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.State = States.New;
        }

        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
