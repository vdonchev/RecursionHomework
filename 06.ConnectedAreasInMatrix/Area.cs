namespace _06.ConnectedAreasInMatrix
{
    using System;

    public class Area : IComparable<Area>
    {
        public Area(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }

        public int Row { get; private set; }

        public int Col { get; private set; }

        public int CompareTo(Area other)
        {
            if (this.Size > other.Size)
            {
                return 1;
            }

            if (this.Size < other.Size)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return string.Format(
                "({0}, {1}), size: {2}",
                this.Row,
                this.Col,
                this.Size);
        }
    }
}