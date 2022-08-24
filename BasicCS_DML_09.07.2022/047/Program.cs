// 47.Написать программу масштабирования фигуры
/*
public class DrawingAreaControl : UserControl
    {
        public DrawingAreaControl()
        {
            DoubleBuffered = true;
            transform = new Matrix();
        }

        public Matrix transform { get; set; }
    
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.Transform = transform;

            base.OnPaint(e);
        }

        const float SCALE_MUL = 1.05f;
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            var matrixOrder = MatrixOrder.Append;
            var K = e.Delta > 0 ? SCALE_MUL : 1 / SCALE_MUL;
            transform.Multiply(new Matrix(1, 0, 0, 1, -e.Location.X, -e.Location.Y), matrixOrder);
            transform.Multiply(new Matrix(K, 0, 0, K, 0, 0), matrixOrder);
            transform.Multiply(new Matrix(1, 0, 0, 1, e.Location.X, e.Location.Y), matrixOrder);

            Invalidate();
        }
    }
    */
