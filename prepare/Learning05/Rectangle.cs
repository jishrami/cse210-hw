public class Rectangle : Shape {
    private double _width;
    private double _height;

    public Rectangle(string color, double height, double width) : base(color) {
        _height = height;
        _width = width;
    }

    public override double GetArea() {
        double area = _width * _height;
        return area;
    }
}
