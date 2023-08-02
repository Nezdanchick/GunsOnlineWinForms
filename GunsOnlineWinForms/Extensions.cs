namespace GunsOnlineWinForms
{
    public static class Extensions
    {
        public static Point Plus(this Point @this, Point other) =>
            new(@this.X + other.X, @this.Y + other.Y);
        public static Point Minus(this Point @this, Point other) =>
            new(@this.X - other.X, @this.Y - other.Y);
    }
}
