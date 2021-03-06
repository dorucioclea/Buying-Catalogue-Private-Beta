/**
 * catalogue-api
 * NHS Digital GP IT Futures Buying Catalog API
 *
 * OpenAPI spec version: 1.0.0-private-beta
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.0-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.CatalogueApi);
  }
}(this, function(expect, CatalogueApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new CatalogueApi.StandardsApplicableApi();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('StandardsApplicableApi', function() {
    describe('apiStandardsApplicableByIdGet', function() {
      it('should call apiStandardsApplicableByIdGet successfully', function(done) {
        //uncomment below and update the code to test apiStandardsApplicableByIdGet
        //instance.apiStandardsApplicableByIdGet(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('apiStandardsApplicableBySolutionBySolutionIdGet', function() {
      it('should call apiStandardsApplicableBySolutionBySolutionIdGet successfully', function(done) {
        //uncomment below and update the code to test apiStandardsApplicableBySolutionBySolutionIdGet
        //instance.apiStandardsApplicableBySolutionBySolutionIdGet(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('apiStandardsApplicableDelete', function() {
      it('should call apiStandardsApplicableDelete successfully', function(done) {
        //uncomment below and update the code to test apiStandardsApplicableDelete
        //instance.apiStandardsApplicableDelete(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('apiStandardsApplicablePost', function() {
      it('should call apiStandardsApplicablePost successfully', function(done) {
        //uncomment below and update the code to test apiStandardsApplicablePost
        //instance.apiStandardsApplicablePost(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('apiStandardsApplicablePut', function() {
      it('should call apiStandardsApplicablePut successfully', function(done) {
        //uncomment below and update the code to test apiStandardsApplicablePut
        //instance.apiStandardsApplicablePut(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));
