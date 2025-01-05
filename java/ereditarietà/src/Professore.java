public class Professore extends Persona{

    private static int nextTesseramento = 0;
    
    private int tesseramento;
    private String materia;

    public Professore(int age, String name, String surname, String materia) {
        super(age, name, surname);
        this.tesseramento = nextTesseramento++;
        this.materia = materia;
    }

    public String getMateria() {
        return materia;
    }

    public int getTesseramento() {
        return tesseramento;
    }
    
}
