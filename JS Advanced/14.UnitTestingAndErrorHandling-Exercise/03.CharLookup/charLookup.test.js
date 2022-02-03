const lookupChar = require('./charLookup.js');
const { assert } = require('chai');

describe('lookup function tests', ()=>{
    it('Return char at index', ()=>{
        assert.equal(lookupChar('Love', 0), 'L')
    });
});