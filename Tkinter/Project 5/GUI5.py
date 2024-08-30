import tkinter as tk
from tkinter import ttk

def button_Func():
    print("A basic button")

window = tk.Tk()
window.title("Buttons")
window.geometry('600x400')

button_string_var = tk.StringVar("Simple button")
button = ttk.Button(master = window, textvariable = button_string_var, command = button_Func)


window.mainloop()