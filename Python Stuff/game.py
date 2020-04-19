#I've never done python before
#I wonder if I can link to other Python files...
class Character:
    def __init__(self, name, level, hp, exp, att, df):
        self.name = str(name) #type-casting isn't needed, but it's useful
        self.level = int(level)
        self.hp = int(hp)
        self.exp = int(exp)
        self.att = int(att)
        self.df = int(df)
    def isAlive(self):
        if self.hp > 0:
            return True
        else:
            return False
    def Attack(self,target):
        print(self.name + " attacks " + target.name)
        target.hp -= self.att / target.df
        if Character.isAlive(target) == False:
            print(target.name + " has been defeated.")
    isGood = False
    isBad = False
    def Affiliation(self):
        if self.isGood:
            print(self.name+" is a good guy")
        elif self.isBad:
            print(self.name+" is a bad guy")
        else:
            print(self.name+" has no affiliation")
    def LevelUp(self):
        self.level += 1
        print(self.name + " has upgraded to level "+ str(self.level) + "!")


aege = Character("Aege",1,10,0,10,7)
poisonButterfly = Character("Poison Butterfly",1,20,0,10,5)
#checking values
print("Character name: "+aege.name)
print("Character level: "+str(aege.level))
print("Character hp: "+str(aege.hp))
print("Character experience: "+str(aege.exp))
print("Character is alive: "+str(Character.isAlive(aege)))

aege.isGood = True
aege.isBad = False
Character.Affiliation(aege)
print()

Character.LevelUp(aege)
Character.LevelUp(aege)
print()