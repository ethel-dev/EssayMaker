# Contributing to EssayMaker
EssayMaker is open source, and I've put an emphasis on community development since the first time I uploaded it in 2011. There are just a few conventions you might want to consider before submitting a pull request.

## Important Things To Know
There are a total of 4 source files and 3 languages you will most likely use the most while contributing to EssayMaker.

1. [CoffeeScript](http://coffeescript.org/) (`src/coffee/save.coffee` and `src/coffee/context.coffee`)
	- `save.coffee` is for all essay saving functions.
	- `context.coffee` is for all design and UI related functions.
	- Please **do not** edit the JavaScript files in the `src/coffee/js` folder directly. Those are just compiled versions of the two main CoffeeScript files.
2. HTML (`index.html`)
3. CSS (`src/styles.css`)

There are also a few important commands available to you when developing for EssayMaker.

To **set up** EssayMaker:
```shell
gulp setup
```

To **watch** CoffeeScript:
```shell
coffee --bare -o src/coffee/js -cw src/coffee
```

To **compile** CoffeeScript:
```shell
gulp coffee
```

To **wire dependencies**:
```shell
gulp wiredep
```

## Naming Conventions
When writing in HTML, please use dashes to `separate-words` in variables.

When writing in CoffeeScript, please use `lowerCamelCase` with all methods, variables, and object properties. Please use `UpperCamelCase` when naming a class, if you ever build one. Don't know why you would.

---

When you're all done, commit to your fork and then from GitHub make a pull request to the main EssayMaker repo.
