using System.Numerics;
using System.Text.Json.Serialization;

namespace NE_DLL.RigidBody
{
    public static class Vector3Extenstions
    {
        public static string ToPrint(this Vector3 v) => $"[ X: {v.X,2:F2}, Y: {v.Y,2:F2}, Z: {v.Z,2:F2} ] ({v.Length(),2:F2})";
    }

    [Serializable]
    public class Force
    {
        /// <summary>
        /// Радіус вектор до точки, де прикладена сила
        /// </summary>
        public Vector3 Position { get; set; }

        private Vector3 _direction; 
        /// <summary>
        /// Нормалізований вектор сили
        /// </summary>
        public Vector3 Direction { 
            get => _direction;
            set {
                _direction = Vector3.Normalize(value);
            }
        }

        /// <summary>
        /// Модуль вектора сили
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// Чи увімкнена сила
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Назва сили
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Виявиляє компоненти вектора сили по осям
        /// </summary>
        /// <returns>Вектор сили</returns>
        public Vector3 GetComponents() => Direction * Value;

        /// <summary>
        /// Виявляє момент сили, що діє на тіло
        /// </summary>
        /// <returns>Вектор моменту сили</returns>
        public Vector3 GetMomentum() => Vector3.Cross(Position, GetComponents());

        public string ToPrint() => $"{Name}{(Enabled ? "     ":" Вимк")} r: {Position.ToPrint()} F: {GetComponents().ToPrint()}   M: {GetMomentum().ToPrint()}";
    }
}
