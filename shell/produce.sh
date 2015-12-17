#!/bin/bash
# this produces essaymaker for github pages
# you most likely won't need this
# it's mostly for releasing, which only @soops does, pretty much

# create dist folder and subfolders
mkdir -p dist/
mkdir -p dist/lib/
mkdir -p dist/src/bootstrap
mkdir -p dist/src/coffee/js

# copy files to dist
cp index.html dist/index.html # html
cp src/favicon.* dist/src # favicon
cp -R lib/ dist/lib/ # dependencies
cp -R src/coffee/js/ dist/src/coffee/js # javascript
cp -R src/bootstrap/ dist/src/bootstrap/ # custom bootstrap
cp -R src/styles.css dist/src/styles.css # css

# minify files inside dist
gulp distribute

# success!
echo "Successfully readied EssayMaker for distribution inside of the 'dist' folder."
