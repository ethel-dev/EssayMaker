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
cp src/favicon.* dist/ # favicon
cp lib/. dist/lib/ -R # dependencies
cp src/coffee/js/. dist/src/coffee/js -R # javascript
cp src/bootstrap/. dist/src/bootstrap/ -R # custom bootstrap
cp src/styles.css dist/src/styles.css -R # css

# minify files inside dist
gulp distribute

# success!
echo "Successfully readied EssayMaker for distribution inside of the 'dist' folder."