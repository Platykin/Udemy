import tkinter as tk
from tkinter import ttk

def button_Func():
    print("A basic button")
    button_string.set("Button Pressed")

window = tk.Tk()
window.title("Buttons")
window.geometry('600x400')

button_string = tk.StringVar()
button = ttk.Button(master = window, command = button_Func, textvariable = button_string)
button.pack()

# Check button
check_var = tk.BooleanVar()
check = ttk.Checkbutton(master = window, 
                        text = "Checkbox 1", 
                        command = lambda : print(check_var.get()),
                        variable = check_var
                        )
check.pack()

# Radio buttons
radio_var = tk.StringVar()
radio1 = ttk.Radiobutton(master = window, text = "Radio button 1", variable = radio_var, value = "radio 1", command = lambda: print(radio_var.get()))
radio1.pack()
radio2 = ttk.Radiobutton(master = window, text = "Radio button 2", variable = radio_var, value = 2, command = lambda: print(radio_var.get()) )
radio2.pack()

# Ex
def radio_func():
    print(check_bool.get())
    check_bool.set(False)


radio_string = tk.StringVar()
check_bool = tk.BooleanVar()

exercise_radio1 = ttk.Radiobutton(window, text = "Radio A", value = "A", command = radio_func, variable = radio_string)
exercise_radio2 = ttk.Radiobutton(window, text = "Radio B", value = "B", command = radio_func, variable = radio_string)

exercise_check = ttk.Checkbutton(window, text = "exercise check", variable = check_bool, command = lambda: print(radio_string.get()))

exercise_radio1.pack()
exercise_radio2.pack()
exercise_check.pack()

window.mainloop()