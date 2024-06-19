using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NE_DLL.RigidBody
{
    public enum RigidBodySystemTypes
    {
        /// <summary>
        /// Система з динамою
        /// </summary>
        Dynamo,
        /// <summary>
        /// Система з рівнодійною силою
        /// </summary>
        NetForce,
        /// <summary>
        /// Система з парою сил (моментом)
        /// </summary>
        MomentumForce,
        /// <summary>
        ///  Відсутній як момент так і рівнодійна сила
        /// </summary>
        Balanced,
    }
    public class RigidBody : ICollection<Force>
    {
        public RigidBody() : this([]) { }
        public RigidBody(IEnumerable<Force> forces) {
            Forces = forces;
            Process();
        }

        private List<Force> _forces = [];
        public IEnumerable<Force> Forces {
            get => _forces;
            set { 
                _forces = new List<Force>(value);
                Process();
            }
        }
       
        #region ICollection Implementation
        public int Count => _forces.Count;

        public bool IsReadOnly => false;

        public void Add(Force item) => _forces.Add(item);

        public void Clear() => _forces.Clear();

        public bool Contains(Force item) => _forces.Contains(item);

        public void CopyTo(Force[] array, int arrayIndex) => _forces.CopyTo(array, arrayIndex);

        public IEnumerator<Force> GetEnumerator() => _forces.GetEnumerator();

        public bool Remove(Force item) => _forces.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion
    
        public void Process()
        {
            (MainForce, MainMomentum) = Forces.Aggregate<Force, (Vector3 force,Vector3 momentum)>((Vector3.Zero, Vector3.Zero), (prev, force) =>
            {
                if (!force.Enabled) return prev;
                return (prev.force + force.GetComponents(), prev.momentum + force.GetMomentum());
            });
        }

        /// <summary>
        /// Рівнодійна сила системи
        /// </summary>
        public Vector3 MainForce { get; private set; }

        /// <summary>
        /// Основний момент системи сил
        /// </summary>
        public Vector3 MainMomentum { get; private set;}


        /// <summary>
        /// Тип до якого зводиться система
        /// </summary>
        public RigidBodySystemTypes SystemType { get {
                if (MainForce.Length() == 0 && MainMomentum.Length() == 0) return RigidBodySystemTypes.Balanced;
                
                if(MainForce.Length() == 0 ) return RigidBodySystemTypes.MomentumForce;
                if(MainMomentum.Length() == 0 ) return RigidBodySystemTypes.NetForce;

                var dotProduct = Vector3.Dot(MainForce, MainMomentum);
                if (dotProduct == 0) return RigidBodySystemTypes.NetForce;

                return RigidBodySystemTypes.Dynamo;
            }
        }

        public string ToPrint()
        {
            string text = $"Сили, що діють на тіло";
            text += Forces.Aggregate("\r\n", (prev, force) =>
            {
                return prev + force.ToPrint() + "\r\n";
            });

            text += $"Рівнодіюча сила: {MainForce.ToPrint()}\r\n" ;
            text += $"Рівнодіюча сила (нормалізована): {Vector3.Normalize(MainForce).ToPrint()}\r\n" ;
            text += $"Головний момент сили: {MainMomentum.ToPrint()}\r\n" ;
            text += $"Головний момент сили (нормалізований):  {Vector3.Normalize(MainMomentum).ToPrint()}\r\n" ;

            text += $"Тип приведення системи: ";
            switch (SystemType)
            {
                case RigidBodySystemTypes.Dynamo:
                    text += "Динамо";
                    break;
                case RigidBodySystemTypes.NetForce:
                    text += "Рівнодіюча сила";
                    break;
                case RigidBodySystemTypes.MomentumForce:
                    text += "Момент сил";
                    break;
                case RigidBodySystemTypes.Balanced:
                    text += "У рівновазі";
                    break;
                default:
                    break;
            }
            text += "\r\n" ;
            return text ;
        }
    }
}
