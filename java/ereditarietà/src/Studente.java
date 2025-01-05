public class Studente extends Persona{

    private static int Nextmatricola = 0;

    private int matricola;
    private String indirizzoStudio;

    public Studente(int age, String name, String surname, String indirizzoStudio) {
        super(age, name, surname);
        this.matricola = ++Nextmatricola;
        this.indirizzoStudio = indirizzoStudio;
    }

    public int getMatricola() {
        return matricola;
    }

    public String getIndirizzoStudio() {
        return indirizzoStudio;
    }
    
    @Override
    public String toString() {
       return super.getPeople() + "indirizzo studio -> "+indirizzoStudio +" matricola -> " + matricola ;
    }
}
