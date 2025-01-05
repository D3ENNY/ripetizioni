public class Cerchio implements Figure{

    private double PIGRECO = 3.14;
    private double raggio;

    public Cerchio(double raggio){
        this.raggio = raggio;    
    }

    @Override
    public double getArea(){
        return Math.pow(raggio, 2)*PIGRECO;
    }

    @Override
    public double getPerimetro(){

        return (2*raggio)*PIGRECO;
    }
    
}
