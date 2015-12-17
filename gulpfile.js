// gulpfile
// used for things i'm too lazy to manually do
var gulp = require('gulp');
var wiredep = require('wiredep').stream;
var uglify = require('gulp-uglify');
var minifyCss = require('gulp-minify-css');
var htmlmin = require('gulp-htmlmin');
var coffee = require('gulp-coffee');
var bower = require('gulp-bower');

// these are default tasks that are done all of the time
gulp.task('default', ['wiredep']);

// setup task for initialization
gulp.task('setup', ['bower', 'coffee', 'wiredep'])

// watches coffee task for changes
gulp.task('watch', function() {
  gulp.watch('src/coffee/*.coffee', ['coffee']);
})

// set up wiredep with index.html
gulp.task('wiredep', function() {
  gulp.src('index.html')
    .pipe(wiredep({
      optional: 'configuration',
      goes: 'here'
    }))
    .pipe(gulp.dest(''));
})

// compile coffee to js
gulp.task('coffee', function() {
  return gulp.src('src/coffee/*.coffee')
    .pipe(coffee({bare:true}))
    .pipe(gulp.dest('src/coffee/js'));
})

// just installs bower dependencies. gotta have a gulp task for everything
gulp.task('bower', function() {
  return bower()
    .pipe(gulp.dest('lib/'));
})

// this is only run when distributing essaymaker
gulp.task('distribute', function() {
  gulp.src('dist/src/coffee/js/*.js')
    .pipe(uglify())
    .pipe(gulp.dest('dist/src/coffee/js'));
  gulp.src('./dist/src/styles.css')
    .pipe(minifyCss({compatibility: 'ie8'}))
    .pipe(gulp.dest('./dist/src'));
  gulp.src('./dist/index.html')
    .pipe(htmlmin({collapseWhitespace: true}))
    .pipe(gulp.dest('./dist'));
});
