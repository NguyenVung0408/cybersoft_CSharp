/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,js}","./node_modules/flowbite/**/*.js"],
  theme: {
    extend: {
      container: {
        center: true,
      },
      backgroundColor:{
        bodyColor: "#151937"
      },
      backgroundImage:{
        'gradient-text':"linear-gradient(to left, #FC8E51, #FA61F9)"
      },
      textColor:{
        profileColor:"#9334e9"
      },
      borderColor:{
        profileColor:"#9334e9"
      },

    },
  },
  plugins: [require('flowbite/plugin')],
}

