namespace Class_Box
{
    using System;
    using System.Text;


    public class Box
    {
        private double length;

        private double width;

        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }


        public double Width
        {
            get => this.width;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }

        }

        public double Height
        {
            get => this.height;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }


        public double LateralSurfaceArea()
        {
            double lateralSurface = 2 * this.length * this.height
                + 2 * this.width * this.height;

            return lateralSurface;
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.length * this.height
                + 2 * this.width * this.height + 2 * this.length * this.width;

            return surfaceArea;
        }

       
        public double Volume()
        {
            double volume = this.length * this.width * this.height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {this.Volume():F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
