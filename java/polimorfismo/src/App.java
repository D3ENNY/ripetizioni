public class App {
    public static void main(String[] args) throws Exception {
        App app = new App();

        //se voglio implementare figure devo ridefinire i metodi, cosa che a noi non serve
       Figure  fig = new Figure() {

        @Override
        public double getPerimetro() {
            return 0;
        }

        @Override
        public double getArea() {
            return 0;
        }
        
       };

       //quindi fare questo

       Figure f1 = new Cerchio(25);   //creo un istanza di cerchio salvata all'interno di una variabile di tipo figure, esso è possibile grazie al polimorfismo
       Figure f2 = new Rettangolo(10, 20); //idem

       Cerchio c1 = new Cerchio(25);
       Rettangolo r1 = new Rettangolo(10, 20);

       app.sumArea(c1,r1);
       app.sumArea(c1, c1);
       app.sumArea(r1, r1);

       if (f1 instanceof Cerchio){
        System.out.println("è un cerchio");
       }

       if(f1 instanceof Rettangolo){
        System.out.println("è un istanza di rettangolo");
       }
    }

    public void sumArea(Figure f1, Figure f2){
        System.out.println("somma -> "+f1.getArea()+f2.getArea());
    }
}
