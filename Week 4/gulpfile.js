// Gulp 4

const { src, dest, series } = require('gulp');
const minifyCSS = require('gulp-csso');
const concat = require('gulp-concat');
const uglify = require('gulp-uglify');
const inject = require('gulp-inject');
const removeCode = require('gulp-remove-code');
var sourcemaps = require('gulp-sourcemaps');
var watch = require('gulp-watch');

function html() {
  return src(['*.html'])
      .pipe(inject(src(['./build/js/*.js', './build/**/*.css'], { read: false }),
        {ignorePath: 'build', addRootSlash: false }))
      .pipe(removeCode({ production: true }))
      .pipe(dest('build'));
}

function js() {
  return src('js/*.js', { sourcemaps: true })
    .pipe(sourcemaps.init())
    .pipe(concat('app.min.js'))
    .pipe(uglify())
    .pipe(sourcemaps.write('.'))
    .pipe(dest('build/js'));
}

function css() {
  return src('css/*.css')
    .pipe(sourcemaps.init())
    .pipe(concat('app.min.css'))
    .pipe(minifyCSS())
    .pipe(sourcemaps.write('.'))
    .pipe(dest('build/css'))
}

function images() {
  return src('images/*.png')
    .pipe(dest('build/images'))
}

function watch_files() {
  watch('src/*.html', html);
  watch('src/js/*.js', js);
  watch('src/css/*.css', css);
}

exports.default = series(js, css, images, html, watch_files);