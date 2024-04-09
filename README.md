# Fish Collector Game
Welcome to Fish Collector, a simple game where you command a ship to collect fish placed in the scene. In this game, you'll use the right mouse button to place fish and the left mouse button to command the ship to collect them. The objective is to collect all the fish in the game.

#How to Play

* Fish Placement
Use the right mouse button to place fish in the water. Each fish appears as a small square in the location you click.

* Ship Movement and Collection
Click on the ship with the left mouse button to activate it. The ship will collect fish in the order they were placed, moving directly to each fish's location. After collecting a fish, the ship immediately moves towards the next fish in sequence until all placed fish are collected. If additional fish are placed after the ship finishes collecting, click the ship again to start collecting new ones. The ship collects fish from oldest to newest or nearest, based on their placement time.

# Polymorphism and Inheritance
This game focuses on the design and implementation of inheritance and polymorphism.

* Inheritance
Inheritance allows the creation of subclasses that inherit attributes and methods from a superclass. In this game, the Fish class serves as the superclass, and there are subclasses for different types of fish (regular, burning, exploding).

* Polymorphism
Polymorphism enables objects of different types to be treated as objects of a common superclass.

* Run-time Polymorphism (Dynamic Polymorphism): Achieved through the destroyFish method overriding. Each subclass of Fish overrides the destroyFish method to provide its own implementation. When a fish is destroyed, the appropriate overridden method is called based on the type of fish. This allows for different behaviors (such as animations for burning and exploding fish) while using a common interface.

# Additional Notes
-Fish are represented as squares in the game.

-Provided animations for burning and exploding fish have been integrated into the destruction process.


# YOUTUBE
Video link https://youtu.be/0Ihk48NGOVU
