import os
path = "./PPR"

for folder in os.listdir(path):
    subFolder = os.listdir(path+"/"+folder)
    for file in subFolder:
        if file.endswith(".exe") or file.endswith(".o"): 
            os.remove(path+"/"+folder+"/"+file)

