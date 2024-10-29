using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StanNaDan.Entiteti
{
    public class AngazujeID
    {
        public virtual SpoljniRadnik SpoljniRadnik { get; set; }

        public virtual Agent Agent { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(AngazujeID))
                return false;

            AngazujeID recievedObject = (AngazujeID)obj;

            if ((SpoljniRadnik.Id == recievedObject.SpoljniRadnik.Id) &&
                (Agent.JMBG == recievedObject.Agent.JMBG))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
