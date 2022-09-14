package java_course;

public class Constructors {
    public static void main(String[] args) {
        Pizza pizza = new Pizza();
        pizza.slices = 8;
        pizza.eat(); // Method invocation
        System.out.println(pizza.slices);

        Pizza pie = new Pizza(6);
        pie.eat(); // Method invocation
        System.out.println(pie.slices);
    }
}

/**
 * Pizza
 */ 
class Pizza {
    int slices;
    String topping;

    Pizza() {}
    Pizza(int pieces) {
        slices = pieces;
    }

    public void eat() { // Method declaration
        slices -= 1;
    }
}
