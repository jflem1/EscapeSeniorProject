const mongoose = require('mongoose')

const userSchema = mongoose.Schema({
    username: {
        type:String, 
        required: [true, "Please provide an Username!"], 
        unique: [true, "username Exist"],
    },
    escapeTime: {
        type:String, 
        required: [true, "Please provide an Email!"], 

    }
})

module.exports = mongoose.model('Users', userSchema, 'users')
