#!/bin/bash
# this is the startup bash file
# if you want to develop essaymaker, please run this to make sure everything works

npm install
bower install
coffee --bare -o src/coffee/js -cw src/coffee
gulp