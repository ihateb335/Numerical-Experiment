using NE_DLL.RigidBody;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace NE_RigidBody
{
    internal class Program
    {
        #region У балансі

        /// <summary>
        /// Система без сил
        /// </summary>
        public static RigidBody TestBalanced0()
        {
            return new RigidBody();
        }

        /// <summary>
        /// Система з двома силами, що врівноважують одна одну
        /// </summary>
        public static RigidBody TestBalanced1()
        {
            var forces = new List<Force> {
                new Force() {
                    Name = "F1",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 2
                }, 
                new Force() {
                    Name = "F2",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = -1 },
                    Value = 2
                },

            };

            return new RigidBody(forces);
        }
        #endregion


        #region Сила та момент

        /// <summary>
        /// Динама з довільним моментом та силою
        /// </summary>
        public static RigidBody TestDynamo0()
        {
            var forces = new List<Force> {
                new Force() {
                    Name = "F1",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 4
                },
                new Force() {
                    Name = "F2",
                    Position = new Vector3 { Y = -2 } ,
                    Direction = new Vector3 { X = -1 },
                    Value = 4
                },
                new Force() {
                    Name = "F3",
                    Position = new Vector3 { Y = 0 } ,
                    Direction = new Vector3 { Z = 1 },
                    Value = 2.5f
                },
            };

            return new RigidBody(forces);
        }

        /// <summary>
        /// Тестовий приклад
        /// </summary>
        public static RigidBody TestDynamoC6_6()
        {
            float a = 30.0f, b = 40.0f, c = 20.0f;
            var forces = new List<Force> {
                new Force() {
                    Name = "P1",
                    Position = new Vector3 { X = a } ,
                    Direction = new Vector3 { X = -1 },
                    Value = 8
                },
                new Force() {
                    Name = "P2",
                    Position = new Vector3 { X = a, Z = c } ,
                    Direction = new Vector3 { Y = 1 },
                    Value = 4
                },
                new Force() {
                    Name = "P3",
                    Position = new Vector3 { X = a, Y = b, Z = c  } ,
                    Direction = new Vector3 { Z = -1 },
                    Value = 6
                },
                new Force() {
                    Name = "P4",
                    Position = new Vector3 { Z = c  } ,
                    Direction = new Vector3 { X = a, Y = b },
                    Value = 20
                },
            };

            return new RigidBody(forces);
        }



        #endregion

        #region Момент
        /// <summary>
        /// Пара сил для моменту
        /// </summary>
        public static RigidBody TestMomentum1()
        {
            var forces = new List<Force> {
                new Force() {
                    Name = "F1",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 4
                },
                new Force() {
                    Name = "F2",
                    Position = new Vector3 { Y = -2 } ,
                    Direction = new Vector3 { X = -1 },
                    Value = 4
                },
            };

            return new RigidBody(forces);
        }

        #endregion

        #region Сила
        /// <summary>
        /// Одна сила у довільній точці
        /// </summary>
        public static RigidBody TestForce0()
        {
            var forces = new List<Force> {
                new Force() {
                    Name = "F1",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 4
                }
            };

            return new RigidBody(forces);
        }
        /// <summary>
        /// Дві співнаправлені сили
        /// </summary>
        public static RigidBody TestForce1()
        {
            var forces = new List<Force> {
                new Force() {
                    Name = "F1",
                    Position = new Vector3 { Y = 2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 4
                },
                new Force() {
                    Name = "F2",
                    Position = new Vector3 { Y = -2 } ,
                    Direction = new Vector3 { X = 1 },
                    Value = 4
                },
            };

            return new RigidBody(forces);
        }
        #endregion


        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF32Encoding.UTF8;

            var body = TestDynamoC6_6();


            Console.WriteLine(body.ToPrint()); 
        }
    }
}
