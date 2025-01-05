public class Rettangolo implements Figure{

    private double base;
    private double altezza;

    public Rettangolo(double base, double altezza){
        this.base = base;
        this.altezza = altezza;
    }

    @Override
    public double getArea(){
        return base*altezza;
    }

    @Override
    public double getPerimetro(){

        return (base*2) + (altezza*2);
    }
}
