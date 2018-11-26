# IComparible Interface

This program implements the IComparible interfaces and their requisite CompareTo methods.
This will allow us to compare objects of a custom type and use useful methods 
such as sorting an array list of custom object.

Both the generic IComparable<T> and non-generic IComparable interfaces are implemented.
While we could just implement one or the other, it's a good idea to implement both for
compatibility reasons. Some collections may use one or the other and might potentially
fail if the interface it requires isn't implemented. By implementing both interfaces, we
can make our class more usable and robust.