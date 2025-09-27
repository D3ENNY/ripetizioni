public class Garage {
    private Auto[] posti;

    public Garage(int maxPosti) {
        this.posti = new Auto[maxPosti];
    }

    public void inserisciAuto(String targa, String marca, String modello){

        for (int i = 0; i < this.posti.length; i++) {
            if(this.posti[i] == null){
                this.posti[i] = new Auto(targa, marca, modello);
                System.out.println("l'auto è stata inserita nel posto N: "+ (i+1));
                break;
            }
        }
    }

    public void rimuoviAuto(String targa){
        for (int i = 0; i < this.posti.length; i++) {
            if(this.posti[i].getTarga().equals(targa)){
                this.posti[i] = null;
                System.out.println("l'auto con targa "+targa+" è uscita dal garage");
                break;
            }
        }
    }

    public void verificaPosto(int nPosto){
        Auto auto = this.posti[nPosto-1];
        if(auto == null)
            System.out.println("il posto " + nPosto+" è libero");
        else
            System.out.println("È Presente la seguente auto:\n  Marca: "+auto.getMarca()+"\n    Modello: "+auto.getModello()+"\n    Targa: "+auto.getTarga());
    }

    public void statoGarage() {
        String output = "";
        for (int i = 0; i < this.posti.length; i++) {
            Auto auto = this.posti[i];

            output += "Posto "+ (i+1);
            if(auto == null)
                output += "\n   libero";
            else
                output += "\n   Marca: "+auto.getMarca()+"\n    Modello: "+auto.getModello()+"\n    Targa: "+auto.getTarga();

            output +="\n\n";
        }
        System.out.println(output);
    }
}
