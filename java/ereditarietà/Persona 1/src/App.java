public class App {
    public static void main(String[] args) throws Exception {
        Persona p1 = new Studente(15, "Luigi", "Verdi", "informatica");     
        Persona p2 = new Studente(18, "Mario", "Rossi", "elettrotecnica");
        Persona p3 = new Professore(45, "Luca", "Bianchi", "italiano");
        Persona p4 = new Professore(35, "Martina", "Russo", "motoria");

        //visto che p1 è un istanza di Studente ha i metodi relativi allo studente, ma grazie all'ereditarietà possiamo usare anche i metodi di persona
        p1.visualizza();
        System.out.println();
        System.out.println("to string => "+ p1.toString());
        System.out.println("studente 1 => "+((Studente)p1).toString());
        System.out.println("studente 2 => "+((Studente)p2).toString());
    }
}
