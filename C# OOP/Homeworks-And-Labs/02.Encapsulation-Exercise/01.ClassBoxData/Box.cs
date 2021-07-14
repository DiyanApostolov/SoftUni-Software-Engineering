namespace _01.ClassBoxData
{
    using System;
    using System.Text;

    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length 
        { 
            get => this.lenght;

            private set 
            {
                this.ValidateSide(value, nameof(this.Length));
                this.lenght = value;
            } 
        }
        public double Width
        {
            get => this.width;
            
            private set
            {
                this.ValidateSide(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            
            private set
            {
                this.ValidateSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        /// <summary>
        /// Volume = lwh
        /// Lateral Surface Area = 2lh + 2wh
        /// Surface Area = 2lw + 2lh + 2wh
        /// </summary>
        public double GetSurfaceArea()
        {
            return (2 * this.lenght * this.width) + (2 * this.lenght * this.height) + (2 * this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.lenght * this.height) + (2 * this.width * this.height);
        }

        public double GetVolume()
        {
            return lenght * width * height;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"Surface Area - {this.GetSurfaceArea():F2}");
            result.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():F2}");
            result.AppendLine($"Volume - {this.GetVolume():F2}");

            return result.ToString().TrimEnd();
        }

        private void ValidateSide(double value, string sideName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{sideName} cannot be zero or negative.");
            }
        }
    }
}
