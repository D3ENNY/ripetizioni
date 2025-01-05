public class App {
    public static void main(String[] args) throws Exception {

        App app = new App();

        String str = "ciao";

        System.out.println("non recursive:");
        app.nonRecursive(str);

        System.out.println("recursive:\n" + app.recursive(str));

    }

    private void nonRecursive(String str) {
        String rts = "";

        for (int i = str.length() - 1; i >= 0; i--)
            rts += str.charAt(i);

        System.out.println(rts);

    }

    private String recursive(String str) {

        if (str.isEmpty())
            return str;
        return recursive(str.substring(1)) + str.charAt(0);

    }
}
