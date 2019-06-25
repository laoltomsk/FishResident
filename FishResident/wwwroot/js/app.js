/******/ (function(modules) { // webpackBootstrap
/******/ 	// install a JSONP callback for chunk loading
/******/ 	function webpackJsonpCallback(data) {
/******/ 		var chunkIds = data[0];
/******/ 		var moreModules = data[1];
/******/ 		var executeModules = data[2];
/******/
/******/ 		// add "moreModules" to the modules object,
/******/ 		// then flag all "chunkIds" as loaded and fire callback
/******/ 		var moduleId, chunkId, i = 0, resolves = [];
/******/ 		for(;i < chunkIds.length; i++) {
/******/ 			chunkId = chunkIds[i];
/******/ 			if(installedChunks[chunkId]) {
/******/ 				resolves.push(installedChunks[chunkId][0]);
/******/ 			}
/******/ 			installedChunks[chunkId] = 0;
/******/ 		}
/******/ 		for(moduleId in moreModules) {
/******/ 			if(Object.prototype.hasOwnProperty.call(moreModules, moduleId)) {
/******/ 				modules[moduleId] = moreModules[moduleId];
/******/ 			}
/******/ 		}
/******/ 		if(parentJsonpFunction) parentJsonpFunction(data);
/******/
/******/ 		while(resolves.length) {
/******/ 			resolves.shift()();
/******/ 		}
/******/
/******/ 		// add entry modules from loaded chunk to deferred list
/******/ 		deferredModules.push.apply(deferredModules, executeModules || []);
/******/
/******/ 		// run deferred modules when all chunks ready
/******/ 		return checkDeferredModules();
/******/ 	};
/******/ 	function checkDeferredModules() {
/******/ 		var result;
/******/ 		for(var i = 0; i < deferredModules.length; i++) {
/******/ 			var deferredModule = deferredModules[i];
/******/ 			var fulfilled = true;
/******/ 			for(var j = 1; j < deferredModule.length; j++) {
/******/ 				var depId = deferredModule[j];
/******/ 				if(installedChunks[depId] !== 0) fulfilled = false;
/******/ 			}
/******/ 			if(fulfilled) {
/******/ 				deferredModules.splice(i--, 1);
/******/ 				result = __webpack_require__(__webpack_require__.s = deferredModule[0]);
/******/ 			}
/******/ 		}
/******/ 		return result;
/******/ 	}
/******/
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// object to store loaded and loading chunks
/******/ 	// undefined = chunk not loaded, null = chunk preloaded/prefetched
/******/ 	// Promise = chunk loading, 0 = chunk loaded
/******/ 	var installedChunks = {
/******/ 		"app": 0
/******/ 	};
/******/
/******/ 	var deferredModules = [];
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	var jsonpArray = window["webpackJsonp"] = window["webpackJsonp"] || [];
/******/ 	var oldJsonpFunction = jsonpArray.push.bind(jsonpArray);
/******/ 	jsonpArray.push = webpackJsonpCallback;
/******/ 	jsonpArray = jsonpArray.slice();
/******/ 	for(var i = 0; i < jsonpArray.length; i++) webpackJsonpCallback(jsonpArray[i]);
/******/ 	var parentJsonpFunction = oldJsonpFunction;
/******/
/******/
/******/ 	// add entry module to deferred list
/******/ 	deferredModules.push(["./main.js","vendor"]);
/******/ 	// run deferred modules when ready
/******/ 	return checkDeferredModules();
/******/ })
/************************************************************************/
/******/ ({

/***/ "./main.js":
/*!*****************!*\
  !*** ./main.js ***!
  \*****************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function($) {

__webpack_require__(/*! ./vendor/modernizr-custom */ "./vendor/modernizr-custom.js");

var _flickityPkgd = __webpack_require__(/*! flickity/dist/flickity.pkgd.min */ "../../node_modules/flickity/dist/flickity.pkgd.min.js");

var _flickityPkgd2 = _interopRequireDefault(_flickityPkgd);

var _responsive = __webpack_require__(/*! ./utils/default/responsive */ "./utils/default/responsive.js");

var _responsive2 = _interopRequireDefault(_responsive);

var _browserDetect = __webpack_require__(/*! ./utils/default/browserDetect */ "./utils/default/browserDetect.js");

var _browserDetect2 = _interopRequireDefault(_browserDetect);

var _getScrollbarWidth = __webpack_require__(/*! ./utils/default/getScrollbarWidth */ "./utils/default/getScrollbarWidth.js");

var _getScrollbarWidth2 = _interopRequireDefault(_getScrollbarWidth);

var _field = __webpack_require__(/*! ./modules/default/field */ "./modules/default/field.js");

var _field2 = _interopRequireDefault(_field);

__webpack_require__(/*! flickity-bg-lazyload */ "../../node_modules/flickity-bg-lazyload/bg-lazyload.js");

__webpack_require__(/*! flickity-imagesloaded */ "../../node_modules/flickity-imagesloaded/flickity-imagesloaded.js");

var _jqForm = __webpack_require__(/*! ./modules/default/jqForm */ "./modules/default/jqForm.js");

var _jqForm2 = _interopRequireDefault(_jqForm);

var _tab = __webpack_require__(/*! ./modules/tab */ "./modules/tab.js");

var _tab2 = _interopRequireDefault(_tab);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

// field focus/fill
// detect browser vendor
$(function () {
    var PApp = {
        UI: {
            $win: $(window),
            $doc: $(document),
            $body: $('body'),
            $header: $('#js-header'),
            $footer: $('#js-footer'),
            $main: $('#js-main')
        },
        screen: {
            width: null,
            height: null
        },
        responsive: new _responsive2.default(),
        browserDetect: new _browserDetect2.default({
            addClass: true
        }),
        scroll: {
            throttle: 0,
            callbackOnInit: true,
            top: 0,
            directionIsBottom: true,
            scrollDelta: 0,
            stylesExist: false,
            getScrollBarWidth: _getScrollbarWidth2.default,
            /**
             * Set overflow on body
             *
             * HOW TO USE:
             * PApp.scroll.overflow('xy', false); // disable overflow by x and y axis
             * PApp.scroll.overflow('x', true); // enable overflow only by x
             *
             * @param {string} prop - (x|y|xy) // axis
             * @param {Boolean} value - false == 'hidden', true == ''
             */
            overflow: function overflow() {
                var prop = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 'xy';
                var value = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : false;

                PApp.UI.$body.removeClass('_overflow-xy _overflow-x _overflow-y');

                if (!this.stylesExist) {
                    var scrollbarWidth = this.getScrollBarWidth();
                    PApp.UI.$body.append('<style id="body-overflow-styles">body._overflow-xy{overflow:hidden!important;max-width:calc(100% - ' + scrollbarWidth + 'px)}body._overflow-x{overflow-x:hidden!important;max-width:calc(100% - ' + scrollbarWidth + 'px)}body._overflow-y{overflow-y:hidden!important;}</style>');
                    this.stylesExist = true;
                }

                PApp.UI.$body.toggleClass('_overflow-' + prop, !value);
            }
        },
        on: {
            init: function init() {
                PApp.browserDetect.check();

                $(window).on('resize.papp_resize', this.resize).on('scroll.papp_scroll', this.scroll);

                this.resize();
            },
            scroll: function scroll() {
                var currentPos = PApp.UI.$win.scrollTop();
                PApp.scroll.top = currentPos;

                if (currentPos < 0) currentPos = 0;

                PApp.scroll.directionIsBottom = currentPos > PApp.scroll.scrollDelta;
                PApp.scroll.scrollDelta = currentPos;
            },
            resize: function resize() {
                PApp.screen.width = PApp.UI.$doc.width();
                PApp.screen.height = PApp.UI.$win.height();
            }
        }
    };
    window.PApp = PApp;
    PApp.on.init();

    new _tab2.default();

    new _field2.default('.js-field');
}); // check responsive
// modernizr (csspointerevents objectfit touchevents)
// import { throttle, debounce } from 'throttle-debounce'; // github.com/niksy/throttle-debounce
// import inViewport  from 'in-viewport'; // github.com/vvo/in-viewport
/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! jquery */ "../../node_modules/jquery/dist/jquery.min.js")))

/***/ }),

/***/ "./modules/default/field.js":
/*!**********************************!*\
  !*** ./modules/default/field.js ***!
  \**********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function($) {

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }(); /* HOW TO USE:
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     default markup:
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     <div class="field js-field">
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         <label>Login</label>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         <input type="text" />
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     </div>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     const fiels = new Field('.js-field');
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     default methods:
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     fiels.update(); // init fields for not inited inputs
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     default events:
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     focusin - add class to .js-field "field--focusin"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     focusout - remove class to js-field "field--focusin"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     if element.val().length > 0 then .js-field have 'field--filled' class
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     */

// import IMask from 'imask/dist/imask.min'; // https://unmanner.github.io/imaskjs/
// ^ enable on 79-83 str


var _genId = __webpack_require__(/*! ../../utils/default/genId */ "./utils/default/genId.js");

var _genId2 = _interopRequireDefault(_genId);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Field = function () {
    /**
     * @param {string} selector
     */
    function Field() {
        var _this = this;

        var selector = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : '.field';

        _classCallCheck(this, Field);

        this.selector = selector;
        this.$fields = $(selector);

        this.genId = new _genId2.default();

        this.destroy = function () {
            return _this.$fields.trigger('destroy');
        };

        this.$fields.each(function (i, el) {
            return _this.UIBinding(el);
        });
    }

    /**
     * Bind HTML input
     *
     * @param {HTMLElement} el
     * @returns {Field|boolean}
     * @constructor
     */


    _createClass(Field, [{
        key: 'UIBinding',
        value: function UIBinding(el) {
            if ($(el).data('_field-inited') === true) {
                return false;
            }

            var self = $(el);

            self.data('_field-inited', true);

            var input = self.children('input, textarea') || self.children('select') || self.children('checkbox');

            if (input.length) {
                var label = input.prev('label');

                if (!label.length) {
                    label = input.next('label');
                }

                var UNIQUE = 'field-uid-' + this.genId.gen();

                if (label.length) {
                    if (!label.attr('for') && label.attr('for') !== '') {
                        label.attr('for', '' + UNIQUE);
                    }

                    if (!input.attr('id') && input.attr('id') !== '') {
                        input.attr('id', UNIQUE);
                    }
                }

                label.click(function () {
                    return input.focus();
                });

                input.on('focusin focusout', Field.check).on('reset', function inputReset() {
                    $(this).val('').removeClass('valid error _filled _focused');
                }).one('destroy', function inputDestroy() {
                    if (typeof $(this).data('mask') !== 'undefined') {
                        $(this).data('mask').destroy();
                    }

                    $(this).off('reset');
                    label.off('click');
                });

                // if (input.is('[type="tel"]') || input.hasClass('js-tel-mask')) {
                //     input.data('mask', new IMask(input[0], {
                //         mask: '+{7}(000)000-00-00'
                //     }));
                // }

                if (input.is(':focus') || input.val().length > 0) {
                    self.addClass('_focused');
                }
            }

            return this;
        }

        /**
         * @param {event} e
         */

    }, {
        key: 'update',
        value: function update() {
            var _this2 = this;

            this.$fields = $(this.selector);
            this.$fields.filter(function updateFilter() {
                return $(this).data('_field-inited') === true;
            }).each(function (i, el) {
                return _this2.UIBinding(el);
            });
        }
    }], [{
        key: 'check',
        value: function check(e) {
            var input = $(e.target);
            var parent = $(e.target).parent();

            parent.toggleClass('_filled', input.val().length > 0).toggleClass('_focused', input.is(':focus') || e.type === 'focusin');
        }
    }]);

    return Field;
}();

exports.default = Field;
/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! jquery */ "../../node_modules/jquery/dist/jquery.min.js")))

/***/ }),

/***/ "./modules/default/jqForm.js":
/*!***********************************!*\
  !*** ./modules/default/jqForm.js ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function($) {

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

__webpack_require__(/*! jquery-validation/dist/jquery.validate.min */ "../../node_modules/jquery-validation/dist/jquery.validate.min.js");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

// https://jqueryvalidation.org/documentation/
// import 'jquery-form/dist/jquery.form.min'; // https://github.com/jquery-form/form

/**
 * HOW TO USE:
 * const formInstance = new JQForm('.js-validate', {
 *     submitHandler: function () {
 *         alert()
 *     }
 * }); // create one instance for one element with selector, and bind submit handler
 *
 * formInstance.destroy(); // destroy all instances
 * formInstance.init(); // destroy all instances with predefined options
 * formInstance.save(); // saved form data to $form.data('saved') and return serialized JSON if $forms count is 1 else returns array of JSON objects
 * formInstance.restore(); // restore form data from $form.data('saved') or JSON or array JSON objects
 * formInstance.clear(); // clear all text inputs, textarea, unselect checkboxes
 */

var JQForm = function () {
    /**
     * @param {string} formsSelector - form selector
     * @param {Object} validationOpt - jquery validation options
     */
    function JQForm(formsSelector) {
        var validationOpt = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : {};

        _classCallCheck(this, JQForm);

        this.validationOpt = $.extend({
            errorPlacement: function errorPlacement() {
                return false;
            },
            highlight: function highlight(element, errorClass, validClass) {
                $(element).parent().addClass(errorClass).removeClass(validClass).attr('title', element.validationMessage);
            },
            unhighlight: function unhighlight(element, errorClass, validClass) {
                $(element).parent().removeClass(errorClass).addClass(validClass).attr('title', null);
            }
        }, validationOpt);
        this.$forms = $(formsSelector);
        this.instances = [];

        this.init();
    }

    /**
     * Init validation instance for each form
     *
     * @returns {JQForm}
     */


    _createClass(JQForm, [{
        key: 'init',
        value: function init() {
            var _this = this;

            this.$forms.each(function (i, el) {
                return _this.instances.push($(el).validate(_this.validationOpt));
            });
            return this;
        }

        /**
         * Destroy all instances
         *
         * @returns {JQForm}
         */

    }, {
        key: 'destroy',
        value: function destroy() {
            this.instances.forEach(function (instance) {
                return instance.destroy();
            });
            this.instances.length = 0;
            return this;
        }

        /**
         * Saved form data
         *
         * @param {$} $form
         * @param {Boolean} toData - to $form.data('saved')
         * @returns {(Object|Object[])} - serialized JSON if $forms count is 1 else returns array of JSON objects
         */

    }, {
        key: 'save',
        value: function save() {
            var $forms = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : this.$forms;
            var toData = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : true;

            var isMultiple = $forms.length > 1;

            var data = void 0;
            var dataArr = [];

            $forms.each(function (i, form) {
                data = $(form).serializeArray();

                if (toData) {
                    $(form).data('saved', data);
                }

                if (isMultiple) {
                    dataArr.push(data);
                }
            });

            return isMultiple ? dataArr : data;
        }

        /**
         * Restore form data from $form.data('saved') or JSON or array JSON objects
         *
         * @param {Object} $form - Jquery object
         * @param {Boolean} fromData - from $(form).data('saved')
         * @param {Object|Object[]} data - from input Object[] or Object
         */

    }, {
        key: 'restore',
        value: function restore() {
            var $forms = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : this.$forms;
            var fromData = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : true;
            var data = arguments[2];

            $forms.each(function (i, form) {
                data = fromData ? $(form).data('saved') : data;

                if (data.length === 'number') {
                    data = data[i];
                }

                data.forEach(function (input) {
                    var attr = '[name=\'' + input.name + '\']';
                    var $input = $(form).find('input' + attr + ', select' + attr + ', textarea' + attr);

                    if ($input.is('[type=checkbox]')) {
                        var $checkbox = $input.filter('[value="' + input.value + '"]');

                        if ($checkbox.length) {
                            $checkbox.prop('checked', true).trigger('change');
                        }
                    } else if ($input.is('[type=radio]')) {
                        var $inputs = $input.filter('[value="' + input.value + '"]');

                        if ($inputs.length) {
                            $inputs.prop('checked', true).trigger('change');
                        }
                    } else {
                        $input.val(input.value).trigger('change');
                    }
                });
            });
        }

        /**
         * Clear all text inputs, textarea, unselect checkboxes
         *
         * @param {Object} $form
         */

    }, {
        key: 'clear',
        value: function clear() {
            var $forms = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : this.$forms;

            var cleanValSelectors = 'input[type=text], input[type=email], input[type=tel], input[type=password], textarea, input[type=number], input[type=search]';
            var removeClassSelectors = '._filled, ._focused, .error, ._success, .checkbox';
            var classesToRemove = '_filled, _focused, error, _success';

            $forms.find(cleanValSelectors).val('').end().find(removeClassSelectors).removeClass(classesToRemove.replace(',', '')).end().find('input[type=checkbox]').prop('checked', false);
        }
    }]);

    return JQForm;
}();

exports.default = JQForm;
/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! jquery */ "../../node_modules/jquery/dist/jquery.min.js")))

/***/ }),

/***/ "./modules/tab.js":
/*!************************!*\
  !*** ./modules/tab.js ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
/* WEBPACK VAR INJECTION */(function($) {

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _throttleDebounce = __webpack_require__(/*! throttle-debounce */ "../../node_modules/throttle-debounce/dist/index.esm.js");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var Tabs = function Tabs() {
    var _this = this;

    _classCallCheck(this, Tabs);

    var $container = $('#js-tabs');

    if (!$container.length) {
        return;
    }

    Object.assign(this, {
        UI: {
            $btns: $container.find('.search__button')
        },

        activateTab: function activateTab() {
            var index = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 0;

            this.UI.$btns.removeClass('_active').eq(index).addClass('_active');
        }
    });

    this.activateTab();

    this.UI.$btns.each(function (i, el) {
        $(el).click(function () {
            _this.activateTab(i);
        });
    });
};

exports.default = Tabs;
/* WEBPACK VAR INJECTION */}.call(this, __webpack_require__(/*! jquery */ "../../node_modules/jquery/dist/jquery.min.js")))

/***/ }),

/***/ "./utils/default/browserDetect.js":
/*!****************************************!*\
  !*** ./utils/default/browserDetect.js ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

/**
 * Detect browser by user agent (Singleton)
 *
 * HOW TO USE
 * const browserDetect = new BrowserDetect({
 *     addClass: true
 * }); // create instance and add class with browser name to body
 * DetectInstance.check('chrome'); // return true if chrome
 *
 * @param {Object} userOptions
 * @returns {*}
 * @constructor
 */
var BrowserDetect = function BrowserDetect(userOptions) {
    _classCallCheck(this, BrowserDetect);

    if (BrowserDetect.instance) {
        return BrowserDetect.instance;
    }

    BrowserDetect.instance = this;

    var DEFAULT_OPTIONS = {
        addClass: false
    };

    var options = {
        is: userOptions.is || DEFAULT_OPTIONS.is,
        addClass: userOptions.addClass || DEFAULT_OPTIONS.addClass
    };

    var UA = navigator.userAgent;
    var isChrome = void 0;var isIE = void 0;var isEdge = void 0;var isFF = void 0;var isSafari = void 0;var isOpera = void 0;
    var classAdded = false;

    (function () {
        isChrome = UA.indexOf('Chrome') > -1;
        isIE = UA.indexOf('MSIE') > -1 || /* @cc_on!@ */false || '-ms-scroll-limit' in document.documentElement.style && '-ms-ime-align' in document.documentElement.style;
        isEdge = UA.indexOf('Edge') > -1;
        isFF = UA.indexOf('Firefox') > -1;
        isSafari = UA.indexOf('Safari') > -1;
        isOpera = UA.toLowerCase().indexOf('op') > -1;
        if (isChrome && isSafari || isEdge && isSafari) {
            isSafari = false;
        }
        if (isChrome && isOpera || isEdge && isChrome) {
            isChrome = false;
        }
    })();

    this.check = function (is) {
        var available = options.addClass && !classAdded;

        if (!classAdded && options.addClass) {
            classAdded = true;
        }

        if (isChrome) {
            if (available) document.documentElement.classList.add('is-chrome');
            if (is === 'chrome') return isChrome;
        }

        if (isSafari) {
            if (available) document.documentElement.classList.add('is-safari');
            if (is === 'safari') return isSafari;
        }

        if (isFF) {
            if (available) document.documentElement.classList.add('is-firefox');
            if (is === 'firefox') return isFF;
        }

        if (isIE) {
            if (available) document.documentElement.classList.add('is-ie');
            if (is === 'ie') return isIE;
        }

        if (isOpera) {
            if (available) document.documentElement.classList.add('is-opera');
            if (is === 'opera') return isOpera;
        }

        if (isEdge) {
            if (available) document.documentElement.classList.add('is-edge');
            if (is === 'edge') return isEdge;
        }

        return false;
    };

    return this;
};

exports.default = BrowserDetect;

/***/ }),

/***/ "./utils/default/genId.js":
/*!********************************!*\
  !*** ./utils/default/genId.js ***!
  \********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

/**
 * Generate unique value (Singleton)
 * HOW TO USE:
 * const genId = new GenID(); // create instance
 * genId.gen(); // get unique value by default; example: 'JT83YWEPRVJQW'
 * genId.gen(2); // get unique value by bit depth; example 2 return 1011010010111101001011111111000001111110000001
 *
 * @returns {GenID}
 * @constructor
 */
var GenID = function () {
    function GenID() {
        _classCallCheck(this, GenID);

        if (GenID.instance) {
            return GenID.instance;
        }

        GenID.instance = this;

        this.inner = [];
    }

    _createClass(GenID, [{
        key: "unique",
        value: function unique(id) {
            var nonUnique = this.inner.filter(function (actID) {
                return actID === id;
            }).length > 0;
            return nonUnique ? false : id;
        }

        /**
         * Generate unique value
         *
         * @param {number} len
         * @returns {boolean|*}
         */

    }, {
        key: "gen",
        value: function gen() {
            var len = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 36;

            var id = false;
            while (!id) {
                id = this.unique((Date.now().toString(len) + Math.random().toString(len).substr(2, 5)).toUpperCase());
            }
            this.inner.push(id);
            return id;
        }
    }], [{
        key: "resetInner",
        value: function resetInner() {
            this.inner = [];
        }
    }]);

    return GenID;
}();

exports.default = GenID;

/***/ }),

/***/ "./utils/default/getScrollbarWidth.js":
/*!********************************************!*\
  !*** ./utils/default/getScrollbarWidth.js ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.default = getScrollBarWidth;
/**
 * Get scrollbar width
 * HOW TO USE:
 * getScrollBarWidth(); // returns number of pixels; example 17
 * @returns {number}
 */
function getScrollBarWidth() {
    var inner = document.createElement('p');
    inner.style.width = '100%';
    inner.style.height = '200px';

    var outer = document.createElement('div');
    outer.style.position = 'absolute';
    outer.style.top = '0px';
    outer.style.left = '0px';
    outer.style.visibility = 'hidden';
    outer.style.width = '200px';
    outer.style.height = '150px';
    outer.style.overflow = 'hidden';
    outer.appendChild(inner);

    document.body.appendChild(outer);
    var w1 = inner.offsetWidth;
    outer.style.overflow = 'scroll';
    var w2 = inner.offsetWidth;

    if (w1 === w2) {
        w2 = outer.clientWidth;
    }

    document.body.removeChild(outer);

    return w1 - w2;
}

/***/ }),

/***/ "./utils/default/mergeDeep.js":
/*!************************************!*\
  !*** ./utils/default/mergeDeep.js ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});

var _typeof = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; };

exports.isObject = isObject;
exports.mergeDeep = mergeDeep;

var _objectAssignPolyfill = __webpack_require__(/*! ./objectAssignPolyfill */ "./utils/default/objectAssignPolyfill.js");

var _objectAssignPolyfill2 = _interopRequireDefault(_objectAssignPolyfill);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

/**
 * Simple object check.
 *
 * @param {Object} item
 * @returns {boolean}
 */
function isObject(item) {
    return item && (typeof item === 'undefined' ? 'undefined' : _typeof(item)) === 'object' && !Array.isArray(item);
}

/**
 * Deep merge two objects.
 *
 * @param {Object} target
 * @param {[Object]} ...sources
 */
function mergeDeep(target) {
    for (var _len = arguments.length, sources = Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
        sources[_key - 1] = arguments[_key];
    }

    if (!sources.length) return target;
    var source = sources.shift();

    if (isObject(target) && isObject(source)) {
        (0, _objectAssignPolyfill2.default)();

        Object.keys(source).forEach(function (key) {
            if (isObject(source[key])) {
                if (!target[key]) Object.assign(target, _defineProperty({}, key, {}));
                mergeDeep(target[key], source[key]);
            } else {
                Object.assign(target, _defineProperty({}, key, source[key]));
            }
        });
    }

    return mergeDeep.apply(undefined, [target].concat(sources));
}

/***/ }),

/***/ "./utils/default/objectAssignPolyfill.js":
/*!***********************************************!*\
  !*** ./utils/default/objectAssignPolyfill.js ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.default = objectAssignPolyfill;
/**
 * https://developer.mozilla.org/ru/docs/Web/JavaScript/Reference/Global_Objects/Object/assign
 */
function objectAssignPolyfill() {
    if (!Object.assign) {
        Object.defineProperty(Object, 'assign', {
            enumerable: false,
            configurable: true,
            writable: true,
            value: function value(target) {
                if (target === undefined || target === null) {
                    throw new TypeError('Cannot convert first argument to object');
                }

                var to = Object(target);

                for (var _len = arguments.length, targets = Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
                    targets[_key - 1] = arguments[_key];
                }

                for (var i = 1; i < targets.length; i++) {
                    var nextSource = targets[i];
                    if (nextSource === undefined || nextSource === null) {
                        continue;
                    }
                    nextSource = Object(nextSource);

                    var keysArray = Object.keys(Object(nextSource));
                    for (var nextIndex = 0, len = keysArray.length; nextIndex < len; nextIndex++) {
                        var nextKey = keysArray[nextIndex];
                        var desc = Object.getOwnPropertyDescriptor(nextSource, nextKey);
                        if (desc !== undefined && desc.enumerable) {
                            to[nextKey] = nextSource[nextKey];
                        }
                    }
                }
                return to;
            }
        });
    }
}

/***/ }),

/***/ "./utils/default/responsive.js":
/*!*************************************!*\
  !*** ./utils/default/responsive.js ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


Object.defineProperty(exports, "__esModule", {
    value: true
});

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _mergeDeep = __webpack_require__(/*! ./mergeDeep */ "./utils/default/mergeDeep.js");

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

/**
 * HOW TO USE:
 * const responsive = new Responsive(); // create instance (Singleton)
 *
 * // check max-width
 * responsive.check('mobileSm') == responsive.mobileSm(); // return true if window width <= 767px
 * ...
 * responsive.check('tablet') == responsive.tablet(); // return true if window width <= 1170px
 *
 * // check min-width
 * responsive.check('desktop', 'min') == responsive.desktop(); // return true if window width > 1170px
 * responsive.check('desktopLg', 'min') == responsive.desktopLg(); // return true if window width > 1600px
 *
 * responsive.isHorizontal(); // return true if browser window landscape orientation
 * responsive.isVertical(); // return true if browser window portrait orientation
 */

var Responsive = function () {
    /**
     * @param {Object} breakpoints
     */
    function Responsive() {
        var _this = this;

        var breakpoints = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : {};

        _classCallCheck(this, Responsive);

        if (Responsive.instance) {
            return Responsive.instance;
        }

        Responsive.instance = this;

        breakpoints = (0, _mergeDeep.mergeDeep)({
            desktopLg: 1600,
            desktop: 1171,
            tablet: 1170,
            tabletV: 1023,
            mobileLg: 767,
            mobileMd: 460,
            mobileSm: 360
        }, breakpoints);

        Object.keys(breakpoints).forEach(function (breakpoint) {
            var param = breakpoint.indexOf('desktop') !== -1 ? 'min' : 'max';
            _this[breakpoint] = function () {
                return _this.check(breakpoints[breakpoint], param);
            };
        });

        this.isHorizontal = function () {
            return window.matchMedia('(orientation: landscape)').matches || document.documentElement.clientWidth > window.innerHeight;
        };

        this.isVertical = function () {
            return !_this.isHorizontal();
        };
    }

    /**
     * @param {number} breakpoint
     * @param {string} [(min|max)] m
     * @returns {boolean}
     */


    _createClass(Responsive, null, [{
        key: 'check',
        value: function check(breakpoint) {
            var m = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : 'max';

            return window.matchMedia('(' + m + '-width: ' + breakpoint + 'px)').matches;
        }
    }]);

    return Responsive;
}();

exports.default = Responsive;

/***/ })

/******/ });