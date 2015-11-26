// gulpfile

var gulp = require('gulp');
var wiredep = require('wiredep').stream;

gulp.task('default', function() {
  gulp.src('index.html')
    .pipe(wiredep({
      optional: 'configuration',
      goes: 'here'
    }))
    .pipe(gulp.dest(''));
});