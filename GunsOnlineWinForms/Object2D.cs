namespace GunsOnlineWinForms
{
    class Object2D : IDisposable
    {
        public Point Position { get; private set; }
        public int HitboxWidth { get; private set; }
        public int HitboxHeight { get; private set; }

        private Image? _image;

        public Object2D() { }
        public Object2D(Image image)
        {
            SetImage(image);
        }
        public void SetImage(Image image) =>
            _image = image;
        public void Move(Point velocity)
        {
            Position = Position.Plus(velocity);
        }

        public void Dispose()
        {
            _image?.Dispose();
        }

        // move()
        // event on collision
        // draw()
    }
}
