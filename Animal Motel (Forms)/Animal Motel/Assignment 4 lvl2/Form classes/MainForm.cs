/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  To handle the communication with the user through an user interface.
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class handles the communication of the program with the user. It displays an windows form for the user. 
    /// </summary>
    public partial class MainForm : Form
    {
        private AnimalManager animalMngr;
        private RecipeManager recipeMngr;
        private int animalID;
        private string filePath;
        private string XMLfilePath;

        /// <summary>
        /// This constructor opens up the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            TimerStart();
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        private void TimerStart()
        {
            lblTime.Text = "Current time\n" + DateTime.Now.ToString("HH:mm:ss");
            timerClock.Start();
        }

        /// <summary>
        /// Initializes the GUI
        /// </summary>
        private void InitializeGUI()
        {
            animalMngr = new AnimalManager();
            recipeMngr = new RecipeManager();
            filePath = string.Empty;
            XMLfilePath = string.Empty;
            ClearGUI();
            this.Icon = Properties.Resources.Icons8_Ios7_Animals_Dog_House;
            this.Text = "Animal Motel";
            btnDelete.Enabled = false;
            UpdateListBoxRegistry();
            UpdateListBoxRecipeStaff();
            AddToListBoxGender();
            AddToListBoxCategory();
            lblCurrentFile.Text = string.Empty;
            lblCurrentXMLFile.Text = string.Empty;
        }

        /// <summary>
        /// Creates a new random ID
        /// </summary>
        private void CreateNewID()
        {
            Random rand = new Random();
            int tempID;
            tempID = rand.Next(1000, 9999);
            if (tempID != animalID)
                animalID = tempID;
            else
                CreateNewID();
        }

        /// <summary>
        /// Fills the gender-listbox with appropriate types
        /// </summary>
        private void AddToListBoxGender()
        {
            ClearListBoxGender();
            listBoxGender.Items.AddRange(Enum.GetNames(typeof(Gender.GenderType)));
        }

        /// <summary>
        /// Clears the gender-listbox
        /// </summary>
        private void ClearListBoxGender()
        {
            listBoxGender.Items.Clear();
        }

        /// <summary>
        /// Fills the category-listbox with appropriate types
        /// </summary>
        private void AddToListBoxCategory()
        {
            ClearListBoxCategory();
            listBoxCategory.Items.AddRange(Enum.GetNames(typeof(Category.CategoryType)));
        }

        /// <summary>
        /// Clears the category-listbox
        /// </summary>
        private void ClearListBoxCategory()
        {
            listBoxCategory.Items.Clear();
        }

        /// <summary>
        /// Updates the listbox containing the animal registry
        /// </summary>
        private void UpdateListBoxRegistry()
        {
            listBoxRegList.Items.Clear();
            btnDelete.Enabled = false;
            btnUnselect.Enabled = false;

            if (animalMngr != null)
            {
                for (int index = 0; index < animalMngr.MyList.Count; index++)
                    listBoxRegList.Items.Add(animalMngr.GetAt(index).ToString());
            }
        }

        /// <summary>
        /// Updates the listbox containing the recipy/staff registry
        /// </summary>
        private void UpdateListBoxRecipeStaff()
        {
            listBoxRecipe.Items.Clear();

            if (recipeMngr != null)
            {
                for (int index = 0; index < recipeMngr.MyList.Count; index++)
                    listBoxRecipe.Items.Add(recipeMngr.GetAt(index).ToString());
            }
        }

        /// <summary>
        /// Clears the GUI
        /// </summary>
        private void ClearGUI()
        {
            groupBoxSpecs.Text = "Specification";
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxCategorySpecs.Text = string.Empty;
            textBoxAnimalSpecs.Text = string.Empty;
            lblCategoryCharacteristic.Text = string.Empty;
            lblAnimalCharacteristic.Text = string.Empty;
            listBoxGender.SelectedIndex = -1;
            listBoxCategory.SelectedIndex = -1;
            listBoxAnimalObject.SelectedIndex = -1;
            listBoxRegList.SelectedIndex = -1;
            textBoxCategorySpecs.Enabled = false;
            textBoxAnimalSpecs.Enabled = false;
            listBoxCategory.Enabled = true;
            checkBoxListAllAnimals.Checked = false;
            btnUnselect.Enabled = false;
            btnDelete.Enabled = false;
            pictureBoxAnimalObject.Image = null;
            lblEaterType.Text = string.Empty;
            lblFoodSchedule.Text = string.Empty;
        }

        /// <summary>
        /// Clears the animal object-listbox
        /// </summary>
        private void ClearListBoxAnimalObject()
        {
            listBoxAnimalObject.Items.Clear();
            lblAnimalCharacteristic.Text = string.Empty;
            textBoxAnimalSpecs.Enabled = false;
            lblEaterType.Text = string.Empty;
            lblFoodSchedule.Text = string.Empty;
        }

        /// <summary>
        /// Set appropriate category specifications for the selected type
        /// </summary>
        private void CategorySpecsSelect()
        {
            if (listBoxCategory.SelectedIndex > -1)
            {
                textBoxCategorySpecs.Enabled = true;
                textBoxCategorySpecs.Text = string.Empty;
                textBoxAnimalSpecs.Text = string.Empty;

                if (listBoxCategory.SelectedItem.ToString() == Category.CategoryType.Bird.ToString())
                {
                    ClearListBoxAnimalObject();
                    listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Bird.BirdTypes)));
                    groupBoxSpecs.Text = "Bird Specification";
                    lblCategoryCharacteristic.Text = "Color of bird:";
                }
                else if (listBoxCategory.SelectedItem.ToString() == Category.CategoryType.Insect.ToString())
                {
                    ClearListBoxAnimalObject();
                    listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Insect.InsectTypes)));
                    groupBoxSpecs.Text = "Insect Specification";
                    lblCategoryCharacteristic.Text = "No. of legs:";
                }
                else if (listBoxCategory.SelectedItem.ToString() == Category.CategoryType.Mammal.ToString())
                {
                    ClearListBoxAnimalObject();
                    listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Mammal.MammalTypes)));
                    groupBoxSpecs.Text = "Mammal Specification";
                    lblCategoryCharacteristic.Text = "No. of teeth:";
                }
                else if (listBoxCategory.SelectedItem.ToString() == Category.CategoryType.Marine.ToString())
                {
                    ClearListBoxAnimalObject();
                    listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Marine.MarineTypes)));
                    groupBoxSpecs.Text = "Marine Specification";
                    lblCategoryCharacteristic.Text = "Weight:";
                }
                else if (listBoxCategory.SelectedItem.ToString() == Category.CategoryType.Reptile.ToString())
                {
                    ClearListBoxAnimalObject();
                    listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Reptile.ReptileTypes)));
                    groupBoxSpecs.Text = "Reptile Specification";
                    lblCategoryCharacteristic.Text = "Size:";
                }
            }
            else
                ClearListBoxAnimalObject();
        }

        /// <summary>
        /// Set appropriate animal object specifications for the selected type
        /// </summary>
        private void AnimalSpecsSelect()
        {
            textBoxAnimalSpecs.Enabled = false;
            textBoxAnimalSpecs.Text = string.Empty;

            if (listBoxAnimalObject.SelectedIndex > -1)
            {
                textBoxAnimalSpecs.Enabled = true;
                if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Eagle.ToString())
                {
                    Eagle eagle = new Eagle();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Bird Specification";
                    lblCategoryCharacteristic.Text = "Color of bird:";
                    lblAnimalCharacteristic.Text = "No. of claws:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.eagle;
                    lblEaterType.Text = eagle.GetEaterType().ToString();
                    for (int index = 0; index < eagle.GetFoodSchedule().Count; index++)
                    {
                        currStr = eagle.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Parrot.ToString())
                {
                    Parrot parrot = new Parrot();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Bird Specification";
                    lblCategoryCharacteristic.Text = "Color of bird:";
                    lblAnimalCharacteristic.Text = "Origin of the parrot:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.parrot;
                    lblEaterType.Text = parrot.GetEaterType().ToString();
                    for (int index = 0; index < parrot.GetFoodSchedule().Count; index++)
                    {
                        currStr = parrot.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.Bee.ToString())
                {
                    Bee bee = new Bee();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Insect Specification";
                    lblCategoryCharacteristic.Text = "No. of legs:";
                    lblAnimalCharacteristic.Text = "Type of bee:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.bee;
                    lblEaterType.Text = bee.GetEaterType().ToString();
                    for (int index = 0; index < bee.GetFoodSchedule().Count; index++)
                    {
                        currStr = bee.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.ButterFly.ToString())
                {
                    Butterfly butterfly = new Butterfly();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Insect Specification";
                    lblCategoryCharacteristic.Text = "No. of legs:";
                    lblAnimalCharacteristic.Text = "Color of wings:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.butterfly;
                    lblEaterType.Text = butterfly.GetEaterType().ToString();
                    for (int index = 0; index < butterfly.GetFoodSchedule().Count; index++)
                    {
                        currStr = butterfly.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }

                else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Bear.ToString())
                {
                    Bear bear = new Bear();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Mammal Specification";
                    lblCategoryCharacteristic.Text = "No. of teeth:";
                    lblAnimalCharacteristic.Text = "Color of fur:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.bear;
                    lblEaterType.Text = bear.GetEaterType().ToString();
                    for (int index = 0; index < bear.GetFoodSchedule().Count; index++)
                    {
                        currStr = bear.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Cat.ToString())
                {
                    Cat cat = new Cat();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Mammal Specification";
                    lblCategoryCharacteristic.Text = "No. of teeth:";
                    lblAnimalCharacteristic.Text = "Length of tail [cm]:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.cat;
                    lblEaterType.Text = cat.GetEaterType().ToString();
                    for (int index = 0; index < cat.GetFoodSchedule().Count; index++)
                    {
                        currStr = cat.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Deer.ToString())
                {
                    Deer deer = new Deer();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Mammal Specification";
                    lblCategoryCharacteristic.Text = "No. of teeth:";
                    lblAnimalCharacteristic.Text = "Type of deer:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.deer;
                    lblEaterType.Text = deer.GetEaterType().ToString();
                    for (int index = 0; index < deer.GetFoodSchedule().Count; index++)
                    {
                        currStr = deer.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Dog.ToString())
                {
                    Dog dog = new Dog();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Mammal Specification";
                    lblCategoryCharacteristic.Text = "No. of teeth:";
                    lblAnimalCharacteristic.Text = "Length of tail [cm]:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.dog;
                    lblEaterType.Text = dog.GetEaterType().ToString();
                    for (int index = 0; index < dog.GetFoodSchedule().Count; index++)
                    {
                        currStr = dog.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }

                else if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Dolphin.ToString())
                {
                    Dolphin dolphin = new Dolphin();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Marine Specification";
                    lblCategoryCharacteristic.Text = "Weight:";
                    lblAnimalCharacteristic.Text = "Type of dolphin:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.dolphin;
                    lblEaterType.Text = dolphin.GetEaterType().ToString();
                    for (int index = 0; index < dolphin.GetFoodSchedule().Count; index++)
                    {
                        currStr = dolphin.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Shark.ToString())
                {
                    Shark shark = new Shark();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Marine Specification";
                    lblCategoryCharacteristic.Text = "Weight:";
                    lblAnimalCharacteristic.Text = "Type of shark:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.shark;
                    lblEaterType.Text = shark.GetEaterType().ToString();
                    for (int index = 0; index < shark.GetFoodSchedule().Count; index++)
                    {
                        currStr = shark.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }

                else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Crocodile.ToString())
                {
                    Crocodile croc = new Crocodile();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Reptile Specification";
                    lblCategoryCharacteristic.Text = "Size:";
                    lblAnimalCharacteristic.Text = "Weight of croc [kg]:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.croc;
                    lblEaterType.Text = croc.GetEaterType().ToString();
                    for (int index = 0; index < croc.GetFoodSchedule().Count; index++)
                    {
                        currStr = croc.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Lizard.ToString())
                {
                    Lizard lizard = new Lizard();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Reptile Specification";
                    lblCategoryCharacteristic.Text = "Size:";
                    lblAnimalCharacteristic.Text = "Type of lizard:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.lizard;
                    lblEaterType.Text = lizard.GetEaterType().ToString();
                    for (int index = 0; index < lizard.GetFoodSchedule().Count; index++)
                    {
                        currStr = lizard.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
                else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Snake.ToString())
                {
                    Snake snake = new Snake();
                    string currStr = string.Empty, myStr = string.Empty;
                    groupBoxSpecs.Text = "Reptile Specification";
                    lblCategoryCharacteristic.Text = "Size:";
                    lblAnimalCharacteristic.Text = "Length of snake [m]:";
                    textBoxCategorySpecs.Enabled = true;
                    pictureBoxAnimalObject.Image = Properties.Resources.snake;
                    lblEaterType.Text = snake.GetEaterType().ToString();
                    for (int index = 0; index < snake.GetFoodSchedule().Count; index++)
                    {
                        currStr = snake.GetFoodSchedule().GetFoodSchedule(index);
                        myStr += currStr + "\r\n";
                    }
                    lblFoodSchedule.Text = myStr;
                }
            }
        }

        /// <summary>
        /// Method is being called when a change in the category-listbox occurs
        /// </summary>
        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxListAllAnimals.Checked == false)
                CategorySpecsSelect();
        }

        /// <summary>
        /// Method is being called when a change in the animal object-listbox occurs
        /// </summary>
        private void listBoxAnimalObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalSpecsSelect();
        }

        /// <summary>
        /// Disables and clears textboxes
        /// </summary>
        private void DisableTextBoxes()
        {
            lblCategoryCharacteristic.Text = string.Empty;
            lblAnimalCharacteristic.Text = string.Empty;
            textBoxCategorySpecs.Text = string.Empty;
            textBoxAnimalSpecs.Text = string.Empty;
            listBoxCategory.Enabled = false;
            textBoxCategorySpecs.Enabled = false;
            textBoxAnimalSpecs.Enabled = false;
            lblCategoryCharacteristic.Enabled = true;
        }

        /// <summary>
        /// Method is being called when a change in the "Select all animals"-checkbox occurs
        /// </summary>
        private void checkBoxListAllAnimals_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAnimalObject.Image = null;
            groupBoxSpecs.Text = "Specification";
            if (checkBoxListAllAnimals.Checked)
            {
                ClearListBoxAnimalObject();
                listBoxCategory.SelectedIndex = -1;
                DisableTextBoxes();
                listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Bird.BirdTypes)));
                listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Insect.InsectTypes)));
                listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Mammal.MammalTypes)));
                listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Marine.MarineTypes)));
                listBoxAnimalObject.Items.AddRange(Enum.GetNames(typeof(Reptile.ReptileTypes)));
            }
            else
            {
                ClearListBoxAnimalObject();
                DisableTextBoxes();
                listBoxCategory.Enabled = true;
            }
        }

        /// <summary>
        /// Method is called when a change in the registry listbox occurs.
        /// </summary>
        private void listBoxRegList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegList.SelectedIndex != -1)
            {
                btnUnselect.Enabled = true;
                btnDelete.Enabled = true;

                Animal currAnimal = animalMngr.GetAt(listBoxRegList.SelectedIndex);
                listBoxCategory.SelectedItem = currAnimal.AnimalCategory.ToString();
                listBoxGender.SelectedItem = currAnimal.AnimalGender.ToString();
                listBoxAnimalObject.SelectedItem = currAnimal.AnimalObject;

                textBoxName.Text = currAnimal.Name;
                textBoxAge.Text = currAnimal.Age.ToString();
                textBoxCategorySpecs.Text = currAnimal.GetCategorySpecs();
                textBoxAnimalSpecs.Text = currAnimal.GetAnimalSpecs();
            }
        }

        /// <summary>
        /// Method to add an animal to the AnimalManager class
        /// </summary>
        private void AddAnimal()
        {
            int parsedValue;

            switch ((Category.CategoryType)listBoxCategory.SelectedIndex)
            {
                case Category.CategoryType.Bird:

                    if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Eagle.ToString())
                    {
                        if (!int.TryParse(textBoxAnimalSpecs.Text, out parsedValue))
                        {
                            MessageBox.Show("The Number of Claws box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            textBoxAnimalSpecs.Text = string.Empty;
                            textBoxAnimalSpecs.Focus();
                        }
                        else
                        {
                            int checkNbr = Convert.ToInt32(textBoxAnimalSpecs.Text);
                            if (checkNbr < 1)
                            {
                                MessageBox.Show("The Number of Claws cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                textBoxAnimalSpecs.Text = string.Empty;
                                textBoxAnimalSpecs.Focus();
                            }
                            else
                            {
                                Eagle eagle = new Eagle();
                                eagle.Name = textBoxName.Text;
                                eagle.Age = int.Parse(textBoxAge.Text);
                                eagle.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                eagle.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                eagle.ColorOfBird = textBoxCategorySpecs.Text;
                                eagle.NbrOfClaws = int.Parse(textBoxAnimalSpecs.Text);
                                CreateNewID();
                                eagle.AnimalID = animalID;
                                animalMngr.Add(eagle);
                                ClearGUI();
                            }
                        }
                    }
                    else if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Parrot.ToString())
                    {
                        Parrot parrot = new Parrot();
                        parrot.Name = textBoxName.Text;
                        parrot.Age = int.Parse(textBoxAge.Text);
                        parrot.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                        parrot.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                        parrot.ColorOfBird = textBoxCategorySpecs.Text;
                        parrot.Origin = textBoxAnimalSpecs.Text;
                        CreateNewID();
                        parrot.AnimalID = animalID;
                        animalMngr.Add(parrot);
                        ClearGUI();
                    }

                    break;

                case Category.CategoryType.Insect:

                    if (!int.TryParse(textBoxCategorySpecs.Text, out parsedValue))
                    {
                        MessageBox.Show("The Number of Legs box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBoxCategorySpecs.Text = string.Empty;
                        textBoxCategorySpecs.Focus();
                    }
                    else
                    {
                        int checkNbrOfLegs = Convert.ToInt32(textBoxCategorySpecs.Text);
                        if (checkNbrOfLegs < 1)
                        {
                            MessageBox.Show("The Number of Legs cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            textBoxCategorySpecs.Text = string.Empty;
                            textBoxCategorySpecs.Focus();
                        }
                        else
                        {
                            if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.Bee.ToString())
                            {

                                Bee bee = new Bee();
                                bee.Name = textBoxName.Text;
                                bee.Age = int.Parse(textBoxAge.Text);
                                bee.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                bee.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                bee.NbrOfLegs = int.Parse(textBoxCategorySpecs.Text);
                                bee.TypeOfBee = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                bee.AnimalID = animalID;
                                animalMngr.Add(bee);
                                ClearGUI();

                            }

                            else if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.ButterFly.ToString())
                            {
                                Butterfly butterfly = new Butterfly();
                                butterfly.Name = textBoxName.Text;
                                butterfly.Age = int.Parse(textBoxAge.Text);
                                butterfly.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                butterfly.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;

                                butterfly.NbrOfLegs = int.Parse(textBoxCategorySpecs.Text);
                                butterfly.ColorOfWings = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                butterfly.AnimalID = animalID;
                                animalMngr.Add(butterfly);
                                ClearGUI();

                            }
                        }
                    }

                    break;

                case Category.CategoryType.Mammal:
                    if (!int.TryParse(textBoxCategorySpecs.Text, out parsedValue))
                    {
                        MessageBox.Show("The Number of Teeth box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBoxCategorySpecs.Text = string.Empty;
                        textBoxCategorySpecs.Focus();
                    }
                    else
                    {
                        int checkNbrOfTeeth = Convert.ToInt32(textBoxCategorySpecs.Text);
                        if (checkNbrOfTeeth < 1)
                        {
                            MessageBox.Show("The Number of Teeth cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            textBoxCategorySpecs.Text = string.Empty;
                            textBoxCategorySpecs.Focus();
                        }
                        else
                        {
                            if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Bear.ToString())
                            {
                                Bear bear = new Bear();
                                bear.Name = textBoxName.Text;
                                bear.Age = int.Parse(textBoxAge.Text);
                                bear.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                bear.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                bear.NbrOfTeeth = int.Parse(textBoxCategorySpecs.Text);
                                bear.ColorOfFur = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                bear.AnimalID = animalID;
                                animalMngr.Add(bear);
                                ClearGUI();
                            }

                            else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Cat.ToString())
                            {

                                if (!int.TryParse(textBoxAnimalSpecs.Text, out parsedValue))
                                {
                                    MessageBox.Show("The Length of Tail box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    int checkNbr = Convert.ToInt32(textBoxAnimalSpecs.Text);
                                    if (checkNbr < 0)
                                    {
                                        MessageBox.Show("The Length of Tail cannot be a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        textBoxAnimalSpecs.Text = string.Empty;
                                        textBoxAnimalSpecs.Focus();
                                    }
                                    else
                                    {
                                        Cat cat = new Cat();
                                        cat.Name = textBoxName.Text;
                                        cat.Age = int.Parse(textBoxAge.Text);
                                        cat.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                        cat.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                        cat.NbrOfTeeth = int.Parse(textBoxCategorySpecs.Text);
                                        cat.LengthOfTail = double.Parse(textBoxAnimalSpecs.Text);
                                        CreateNewID();
                                        cat.AnimalID = animalID;
                                        animalMngr.Add(cat);
                                        ClearGUI();
                                    }
                                }
                            }

                            else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Deer.ToString())
                            {
                                Deer deer = new Deer();
                                deer.Name = textBoxName.Text;
                                deer.Age = int.Parse(textBoxAge.Text);
                                deer.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                deer.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                deer.NbrOfTeeth = int.Parse(textBoxCategorySpecs.Text);
                                deer.TypeOfDeer = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                deer.AnimalID = animalID;
                                animalMngr.Add(deer);
                                ClearGUI();
                            }

                            else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Dog.ToString())
                            {
                                if (!int.TryParse(textBoxAnimalSpecs.Text, out parsedValue))
                                {
                                    MessageBox.Show("The Length of Tail box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    int checkNbr = Convert.ToInt32(textBoxAnimalSpecs.Text);
                                    if (checkNbr < 0)
                                    {
                                        MessageBox.Show("The Length of Tail cannot be a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        textBoxAnimalSpecs.Text = string.Empty;
                                        textBoxAnimalSpecs.Focus();
                                    }
                                    else
                                    {
                                        Dog dog = new Dog();
                                        dog.Name = textBoxName.Text;
                                        dog.Age = int.Parse(textBoxAge.Text);
                                        dog.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                        dog.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                        dog.NbrOfTeeth = int.Parse(textBoxCategorySpecs.Text);
                                        dog.LengthOfTail = double.Parse(textBoxAnimalSpecs.Text);
                                        CreateNewID();
                                        dog.AnimalID = animalID;
                                        animalMngr.Add(dog);
                                        ClearGUI();
                                    }
                                }
                            }
                        }
                    }

                    break;

                case Category.CategoryType.Marine:
                    if (!int.TryParse(textBoxCategorySpecs.Text, out parsedValue))
                    {
                        MessageBox.Show("The Weight box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        int checkNbr = Convert.ToInt32(textBoxCategorySpecs.Text);
                        if (checkNbr < 1)
                        {
                            MessageBox.Show("The Weight cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            textBoxCategorySpecs.Text = string.Empty;
                            textBoxCategorySpecs.Focus();
                        }
                        else
                        {
                            if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Dolphin.ToString())
                            {
                                Dolphin dolphin = new Dolphin();
                                dolphin.Name = textBoxName.Text;
                                dolphin.Age = int.Parse(textBoxAge.Text);
                                dolphin.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                dolphin.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                dolphin.Weigth = double.Parse(textBoxCategorySpecs.Text);
                                dolphin.TypeOfDolphin = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                dolphin.AnimalID = animalID;
                                animalMngr.Add(dolphin);
                                ClearGUI();
                            }

                            else if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Shark.ToString())
                            {
                                Shark shark = new Shark();
                                shark.Name = textBoxName.Text;
                                shark.Age = int.Parse(textBoxAge.Text);
                                shark.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                shark.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                shark.Weigth = double.Parse(textBoxCategorySpecs.Text);
                                shark.TypeOfShark = textBoxAnimalSpecs.Text;
                                CreateNewID();
                                shark.AnimalID = animalID;
                                animalMngr.Add(shark);
                                ClearGUI();
                            }
                        }
                    }

                    break;

                case Category.CategoryType.Reptile:

                    if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Crocodile.ToString())
                    {
                        if (!int.TryParse(textBoxAnimalSpecs.Text, out parsedValue))
                        {
                            MessageBox.Show("The Crocodile Weight box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            int checkNbr = Convert.ToInt32(textBoxAnimalSpecs.Text);
                            if (checkNbr < 1)
                            {
                                MessageBox.Show("The Crocodile Weight cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                textBoxAnimalSpecs.Text = string.Empty;
                                textBoxAnimalSpecs.Focus();
                            }
                            else
                            {
                                Crocodile crocodile = new Crocodile();
                                crocodile.Name = textBoxName.Text;
                                crocodile.Age = int.Parse(textBoxAge.Text);
                                crocodile.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                crocodile.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                crocodile.Skin = textBoxCategorySpecs.Text;
                                crocodile.Weight = double.Parse(textBoxAnimalSpecs.Text);
                                CreateNewID();
                                crocodile.AnimalID = animalID;
                                animalMngr.Add(crocodile);
                                ClearGUI();
                            }
                        }
                    }

                    else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Lizard.ToString())
                    {
                        Lizard lizard = new Lizard();
                        lizard.Name = textBoxName.Text;
                        lizard.Age = int.Parse(textBoxAge.Text);
                        lizard.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                        lizard.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                        lizard.Skin = textBoxCategorySpecs.Text;
                        lizard.TypeOfLizard = textBoxAnimalSpecs.Text;
                        CreateNewID();
                        lizard.AnimalID = animalID;
                        animalMngr.Add(lizard);
                        ClearGUI();
                    }

                    else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Snake.ToString())
                    {
                        if (!int.TryParse(textBoxAnimalSpecs.Text, out parsedValue))
                        {
                            MessageBox.Show("The Length of Snake box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            int checkNbr = Convert.ToInt32(textBoxAnimalSpecs.Text);
                            if (checkNbr < 1)
                            {
                                MessageBox.Show("The Length of Snake cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                textBoxAnimalSpecs.Text = string.Empty;
                                textBoxAnimalSpecs.Focus();
                            }
                            else
                            {
                                Snake snake = new Snake();
                                snake.Name = textBoxName.Text;
                                snake.Age = int.Parse(textBoxAge.Text);
                                snake.AnimalGender = (Gender.GenderType)listBoxGender.SelectedIndex;
                                snake.AnimalCategory = (Category.CategoryType)listBoxCategory.SelectedIndex;
                                snake.Skin = textBoxCategorySpecs.Text;
                                snake.LengthOfSnake = double.Parse(textBoxAnimalSpecs.Text);
                                CreateNewID();
                                snake.AnimalID = animalID;
                                animalMngr.Add(snake);
                                ClearGUI();
                            }
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// Method is being called when a change in the "Add new animal"-button occurs
        /// </summary>
        private void btnAddNewAnimal_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (!int.TryParse(textBoxAge.Text, out parsedValue) || textBoxAge.Text == string.Empty)
            {
                MessageBox.Show("The age box is a number only field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxAge.Text = string.Empty;
                textBoxAge.Focus();
            }
            else if (textBoxName.Text == string.Empty || textBoxCategorySpecs.Text == string.Empty || textBoxAnimalSpecs.Text == string.Empty ||
                        listBoxGender.SelectedIndex == -1 || listBoxAnimalObject.SelectedIndex == -1)
                MessageBox.Show("Invalid input or input missing. Please go back and revise.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                int checkNbr = Convert.ToInt32(textBoxAge.Text);
                if (checkNbr < 1)
                {
                    MessageBox.Show("The age cannot be zero or a negative number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxAge.Text = string.Empty;
                    textBoxAge.Focus();
                }
                else
                {
                    if (checkBoxListAllAnimals.Checked == false)
                    {
                        AddAnimal();
                        UpdateListBoxRegistry();
                        AddToListBoxGender();
                        AddToListBoxCategory();
                    }
                    else
                    {
                        if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Eagle.ToString())
                            listBoxCategory.SelectedIndex = 0;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Bird.BirdTypes.Parrot.ToString())
                            listBoxCategory.SelectedIndex = 0;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.Bee.ToString())
                            listBoxCategory.SelectedIndex = 1;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Insect.InsectTypes.ButterFly.ToString())
                            listBoxCategory.SelectedIndex = 1;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Bear.ToString())
                            listBoxCategory.SelectedIndex = 2;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Cat.ToString())
                            listBoxCategory.SelectedIndex = 2;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Dog.ToString())
                            listBoxCategory.SelectedIndex = 2;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Mammal.MammalTypes.Deer.ToString())
                            listBoxCategory.SelectedIndex = 2;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Dolphin.ToString())
                            listBoxCategory.SelectedIndex = 3;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Marine.MarineTypes.Shark.ToString())
                            listBoxCategory.SelectedIndex = 3;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Crocodile.ToString())
                            listBoxCategory.SelectedIndex = 4;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Lizard.ToString())
                            listBoxCategory.SelectedIndex = 4;
                        else if (listBoxAnimalObject.SelectedItem.ToString() == Reptile.ReptileTypes.Snake.ToString())
                            listBoxCategory.SelectedIndex = 4;

                        AddAnimal();
                        UpdateListBoxRegistry();
                        AddToListBoxGender();
                        AddToListBoxCategory();
                    }
                }
            }
        }

        /// <summary>
        /// Method is called when the "Delete" button is pressed in the GUI.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            animalMngr.DeleteAt(listBoxRegList.SelectedIndex);
            UpdateListBoxRegistry();
            btnUnselect_Click(sender, e);
        }

        /// <summary>
        /// Method is called when the "Add Food" button is pressed in the GUI.
        /// </summary>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Recipe recipeObj = new Recipe();
            RecipeForm dlg = new RecipeForm(recipeObj);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(recipeObj.Name))
                {
                    MessageBox.Show("No recipe added! Name of recipe missing!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recipeObj = null;
                }
                else if (recipeObj.IngredientCount <= 0)
                {
                    MessageBox.Show("No recipe added! Ingredients missing!");
                    recipeObj = null;
                }
            }
            else if (dlgResult == DialogResult.Cancel)
                recipeObj = null;

            if (recipeObj != null)
            {
                recipeMngr.Add(recipeObj);
                listBoxRecipe.Items.Add(recipeObj.ToString());
            }
        }

        /// <summary>
        /// Method is called when the "Add Staff" button is pressed in the GUI.
        /// </summary>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Staff staffObj = new Staff();
            StaffForm dlg = new StaffForm(staffObj);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(staffObj.Name))
                {
                    MessageBox.Show("No staffmember added! Name of staffmember missing!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staffObj = null;
                }
            }
            else if (dlgResult == DialogResult.Cancel)
                staffObj = null;

            if (staffObj != null)
                listBoxRecipe.Items.Add(dlg.Staff.ToString());
        }

        /// <summary>
        /// Method is called when the "New" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuNew_Click(object sender, EventArgs e)
        {
            if (listBoxRegList.Items.Count == 0 && listBoxRecipe.Items.Count == 0)
                InitializeGUI();
            else
            {
                var result = MessageBox.Show("You have items in the registries. Continue?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    InitializeGUI();
            }
        }

        /// <summary>
        /// Method is called when the "Exit" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Method is called when the "Unselect" button is pressed in the GUI.
        /// </summary>
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            listBoxRegList.SelectedIndex = -1;
            ClearGUI();
            AddToListBoxGender();
            AddToListBoxCategory();
            UpdateListBoxRegistry();
        }

        /// <summary>
        /// Method is called when the "Save" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
                menuSaveAs_Click(sender, e);
            else
                SaveToFile();
        }

        /// <summary>
        /// Method is called when the "Save As" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                SaveToFile();
            }
        }

        /// <summary>
        /// Serializes the current data in the registry listbox to a binary file.
        /// </summary>
        private void SaveToFile()
        {
            try
            {
                animalMngr.BinarySerialize(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Serializes the current data in the recipe listbox to an XML file.
        /// </summary>
        private void SaveToXMLFile()
        {
            try
            {
                recipeMngr.XMLSerialize<List<Recipe>>(XMLfilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method is called when the "Open" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                try
                {
                    animalMngr.BinaryDeSerialize(filePath);
                    ClearGUI();
                    UpdateListBoxRegistry();
                    AddToListBoxGender();
                    AddToListBoxCategory();
                    lblCurrentFile.Text = "Current file: " + filePath;
                    string strMessage = filePath + "\nis deserialized into an object of " + animalMngr.MyList.Count + " items successfully! ";
                    MessageBox.Show(strMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File not opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Method is called when the "Export to XML file" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuExportXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XMLfilePath = saveFileDialog.FileName;
                SaveToXMLFile();
                XMLfilePath = string.Empty;
            }
        }

        /// <summary>
        /// Method is called when the "Import from XML file" button in the menustrip is pressed in the GUI.
        /// </summary>
        private void menuImportXML_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XMLfilePath = openFileDialog.FileName;
                try
                {
                    recipeMngr.MyList = recipeMngr.XMLDeSerialize<List<Recipe>>(XMLfilePath);

                    ClearGUI();
                    UpdateListBoxRecipeStaff();
                    AddToListBoxGender();
                    AddToListBoxCategory();
                    lblCurrentXMLFile.Text = "Current file: " + XMLfilePath;
                    string strMessage = XMLfilePath + "\nis deserialized into an XML object of " + recipeMngr.MyList.Count + " items successfully! ";
                    MessageBox.Show(strMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File not opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Method is called when clock timer is started. 
        /// </summary>
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Current time\n" + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}