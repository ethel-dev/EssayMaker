// gulpfile
// used for things i'm too lazy to manually do
var gulp = require('gulp');
var wiredep = require('wiredep').stream;
var uglify = require('gulp-uglify');
var minifyCss = require('gulp-minify-css');
var htmlmin = require('gulp-htmlmin');

// these are default tasks that are done all of the time
gulp.task('default', function() {
  gulp.src('index.html')
    .pipe(wiredep({
      optional: 'configuration',
      goes: 'here'
    }))
    .pipe(gulp.dest(''));
});

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