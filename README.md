# BeeApplication

## Classes

### Bee
Base bee class. Has properties for Health, DeathLimit and IsDead.
Has method: Damage(amount). Which inflicts damage upon the bee, if it is not dead.

### Worker Bee
Subclass of Bee. Has Death Limit of 0.7. Meaning if it falls below 70% health, it's dead.

### Queen Bee
Subclass of Bee. Has Death Limit of 0.2. Meaning if it falls below 20% health, it's dead.

### Drone Bee
Subclass of Bee. Has Death Limit of 0.5. Meaning if it falls below 50% health, it's dead.

## Tests
There are multiple test checking the input of the Damage Method on the base bee. And that exceptions are thrown correctly.
Then there are 3 DeathLimit tests to make sure damage is not done to each bee type after they're already dead.
