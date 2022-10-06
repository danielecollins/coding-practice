public class Methods {
    public static void main(String[] args) {
        Methods example = new Methods();
        int returned = example.go();
        System.out.println(returned);

        // Static method call
        int value = Methods.go(22);
        System.out.println(value);
    }

    public int go() {
        return 11;
    }

    // Overloads the go() method so that it can be called without creating an object
    public static int go(int x) {
        return x;
    }
}
