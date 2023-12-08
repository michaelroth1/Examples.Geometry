## Single Responsibility Principle

Each component should have only one sole purpose.
It should not fulfill excessive functionality.

**Violation:**
Whenever a component has an excessive functionality

## Open-Closed Principle
Components/classes should be open 
for extension but closed for modification.

**Violation:**
Rewriting existing code, in case of adding 
new functionality.

**Solution:**
Polymorphism/abstraction

## Liskov Substitution Principle
Every subclass or child class should be 
substitutable for their base or parent class.
A superclass must be replaceable by a child class 
without affecting the correctness/assumption
of the program.

**Violation:**
Replacement of a child class breaks the 
expectations/assumptions of its parent class.

**Solution:**
A child class has to meet all contracts
set by the base class.

## Interface Segregation Principle
Interfaces should not force classes to 
implement something they cannot deliver.
According to the SRP of classes, large interfaces 
should be divided into smaller ones.

## Dependency Inversion Principle
Higher level components should not depend
directly on lower level components. 
Both should only depend on abstractions.

**Violation:**
Direct injections of lower level
components into higher ones

**Solution:**
Polymorphism/abstraction