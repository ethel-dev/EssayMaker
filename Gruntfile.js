module.exports = function(grunt) {

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        wiredep: {
            task: {
                src: [
                    'index.html',
                    'src/styles.sass',
                    'src/styles.scss'
                ],
            }
        }
    });

    grunt.loadNpmTasks('grunt-wiredep');
};