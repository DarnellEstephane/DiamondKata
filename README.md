If I had more time, I would:

- Add full '///' comments above the methods for intellisense support.

- Move the input validation/sanitation from the create method to a separate method to help separate concerns.

- Add some kind of error messaging so it's clear what caused the class to not produce a diamond. (It currently produces an empty string)

- Make the Diamond class more open for extension by adding startPoint and space variables as either optinal parameters or overflow methods to allow for easier re-use if we decide to expand functionality later e.g. Diamonds starting with other letters, displaying lowercase letters or even symbols
