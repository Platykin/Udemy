import tkinter as tk
from tkinter import ttk

def button_func():
    print("A button was pressed")

def hello():
    print("hello")

# Window
window = tk.Tk()
window.title("Window and widgets")
window.geometry("800x600")

# Widgets
text = tk.Text(master = window)
text.pack()

# ttk widgets
label = ttk.Label(master = window, text = "Test")
label.pack()

# ttk entry
entry = ttk.Entry(master = window)
entry.pack()

#############
label_test = ttk.Label(master = window, text = "my label")
label_test.pack()
button_test = ttk.Button(master = window, text = "Button test",command = hello)
button_test.pack()

# ttk button
button = ttk.Button(master = window, text = "A button", command = button_func)
button.pack()



# Run
window.mainloop()