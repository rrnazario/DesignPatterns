# Composition

## Definition

Behavioral pattern which avoid some issues regarding inheritance usage, once that if for this last technique requires many changes over parent class.

---

## Usage

Regarding **S.O.L.I.D.** principles, it pattern is related to **Open and Close Principle** and **Dependency Inversion Principle**.

- **Open and Close Principle**: Software entities should be open  to be extended, but closed to be modified.
- **Dependency Inversion Principle**: Depending on abstractions instead concretes.

---

## Example 

At this example, I created a class *Character* that represents a game character. In a inheritance approach, I could use this class as an *abstract* one and could create a method to set an unique *Damage* property. Classes will extend this one as attacks type (KickCharacter, PunchCharacter). The problem is when you need of a character that mix attacks. The inheritance will be confused.

In composition approach, I created the same *Character* class to be composed, which means that the attacks will be got on demand, according they will be needed. If in another moment other attack be required, you only add it on *CharacterEnums.TypeAttack* enum and, on *Character* class, add properly methods to check and return its damage.