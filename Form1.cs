namespace Car_Service_Shop
{
    public partial class Form1 : Form
    {
        private const decimal TAX_RATE = 0.13m;
        private List<Service> services;

        public Form1()
        {
            InitializeComponent();
            services = new List<Service>();
        }

        private void ServiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCost();
        }

        private void CalculateCost()
        {
            decimal cost = 0;

            if (chkEngineOil.Checked)
                cost += 60;
            if (chkTransmission.Checked)
                cost += 120;
            if (chkAirFilter.Checked)
                cost += 40.50m;

            decimal totalCost = cost * (1 + TAX_RATE);
            txtCost.Text = totalCost.ToString("C2");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Count only the digits in the phone number
            int digitCount = phoneNumber.Count(char.IsDigit);
            return digitCount >= 10;
        }


        private bool ValidateInput()
        {
            var errorMessages = new List<string>();

            // First Name validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errorMessages.Add("First name is required.");
            else if (txtFirstName.Text.Any(char.IsDigit))
                errorMessages.Add("First name cannot contain numbers.");
            else if (txtFirstName.Text.Length < 2)
                errorMessages.Add("First name must be at least 2 characters long.");

            // Phone validation
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorMessages.Add("Phone number is required.");
            }
            else if (!IsValidPhoneNumber(txtPhone.Text))
            {
                errorMessages.Add("Phone number must have at least 10 digits.");
            }
            else if (!txtPhone.Text.All(c => char.IsDigit(c) || c == '-' || c == '(' || c == ')' || c == ' '))
            {
                errorMessages.Add("Phone number can only contain digits, hyphens, parentheses, and spaces.");
            }

            // Car make validation
            if (cboMake.SelectedIndex == -1)
            {
                errorMessages.Add("Please select a car make.");
            }

            // Model validation
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                errorMessages.Add("Model is required.");
            }

            // Color validation
            if (string.IsNullOrWhiteSpace(txtColour.Text))
            {
                errorMessages.Add("Colour is required.");
            }
            else
            {
                string color = txtColour.Text.Trim().ToLower();
                var validColors = new HashSet<string>
                {        
                    "Red", "Blue", "Green", "Yellow", "Purple",
                    "Orange", "Pink", "Brown", "Black",
                    "White", "Gray", "Turquoise", "Magenta",
                    "Indigo", "Violet", "Maroon", "Navy", "Teal",
                    "Olive", "Coral", "Crimson", "Azure", "Beige",
                    "Burgundy", "Chartreuse", "Cyan", "Fuchsia", "Gold",
                    "Lavender", "Lime", "Mauve", "Ochre", "Periwinkle",
                    "Plum", "Rose", "Rust", "Salmon", "Scarlet", "Sienna",
                    "Silver", "Tan", "Taupe", "Vermillion", "Aqua", "Cerulean",
                    "Ivory", "Khaki", "Mahogany", "Mustard", "Peach", "Ruby",
                    "Sapphire", "Slate", "Auburn", "Bronze", "Cobalt",
                    "Emerald", "Jade", "Mint", "Mulberry", "Pearl", "Pine",
                    "Sage", "Sepia", "Brass", "Copper", "Pewter", "Charcoal",
                    "Ash", "Amethyst", "Apricot", "Carmine", "Cerise", "Chestnut",
                    "Chocolate", "Cinnamon", "Coffee", "Cream", "Denim", "Ecru",
                    "Forest", "Garnet", "Hazel", "Honey", "Lemon", "Lilac", "Opal",
                    "Orchid", "Pear", "Pumpkin", "Quartz", "Raspberry", "Seafoam",
                    "Strawberry", "Tangerine", "Topaz", "Vanilla", "Wine", "Grey",
                    "red", "blue", "green", "yellow", "purple",
                    "orange", "pink", "brown", "black",
                    "white", "gray", "turquoise", "magenta",
                    "indigo", "violet", "maroon", "navy", "teal",
                    "olive", "coral", "crimson", "azure", "beige",
                    "burgundy", "chartreuse", "cyan", "fuchsia", "gold",
                    "lavender", "lime", "mauve", "ochre", "periwinkle",
                    "plum", "rose", "rust", "salmon", "scarlet", "sienna",
                    "silver", "tan", "taupe", "vermillion", "aqua", "cerulean",
                    "ivory", "khaki", "mahogany", "mustard", "peach", "ruby",
                    "sapphire", "slate", "auburn", "bronze", "cobalt",
                    "emerald", "jade", "mint", "mulberry", "pearl", "pine",
                    "sage", "sepia", "brass", "copper", "pewter", "charcoal",
                    "ash", "amethyst", "apricot", "carmine", "cerise", "chestnut",
                    "chocolate", "cinnamon", "coffee", "cream", "denim", "ecru",
                    "forest", "garnet", "hazel", "honey", "lemon", "lilac", "opal",
                    "orchid", "pear", "pumpkin", "quartz", "raspberry", "seafoam",
                    "strawberry", "tangerine", "topaz", "vanilla", "wine", "grey"
                };

                if (!validColors.Contains(color))
                {
                    errorMessages.Add("Please enter a valid car color.");
                }
            }

            // Service selection validation
            if (!chkEngineOil.Checked && !chkTransmission.Checked && !chkAirFilter.Checked)
            {
                errorMessages.Add("At least one service must be selected.");
            }

            if (errorMessages.Count > 0)
            {
                MessageBox.Show(
                    string.Join("\n", errorMessages),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

        private Service CreateServiceFromInput()
        {
            decimal cost = decimal.Parse(txtCost.Text.Trim('$'));
            return new Service(
                txtFirstName.Text,
                txtLastName.Text,
                txtPhone.Text,
                cboMake.Text,
                txtModel.Text,
                (int)numYear.Value,
                txtColour.Text,
                chkEngineOil.Checked,
                chkTransmission.Checked,
                chkAirFilter.Checked,
                cost
            );
        }

        private void AddServiceToListView(Service service)
        {
            var item = new ListViewItem(new string[] {
                service.IdentificationNumber.ToString(),
                service.firstName,
                service.lastName,
                service.phoneNumber,
                service.Make,
                service.Model,
                service.Year.ToString(),
                service.Colour,
                GetSelectedServices(service),
                service.Price.ToString("C2")
            });
            lstServices.Items.Add(item);
        }

        private string GetSelectedServices(Service service)
        {
            var selectedServices = new List<string>();
            if (service.EngOilChange) selectedServices.Add("Engine Oil");
            if (service.TransOilChange) selectedServices.Add("Transmission");
            if (service.AirFilterChange) selectedServices.Add("Air Filter");
            return string.Join(", ", selectedServices);
        }

        private void UpdateListView()
        {
            lstServices.Items.Clear();
            foreach (var service in services)
            {
                AddServiceToListView(service);
            }
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cboMake.SelectedIndex = -1;
            txtModel.Clear();
            numYear.Value = DateTime.Now.Year;
            txtColour.Clear();
            chkEngineOil.Checked = false;
            chkTransmission.Checked = false;
            chkAirFilter.Checked = false;
            txtCost.Clear();
            lstServices.SelectedIndices.Clear();
        }

        private void PopulateFormFromService(Service service)
        {
            txtFirstName.Text = service.firstName;
            txtLastName.Text = service.lastName;
            txtPhone.Text = service.phoneNumber;
            cboMake.Text = service.Make;
            txtModel.Text = service.Model;
            numYear.Value = service.Year;
            txtColour.Text = service.Colour;
            chkEngineOil.Checked = service.EngOilChange;
            chkTransmission.Checked = service.TransOilChange;
            chkAirFilter.Checked = service.AirFilterChange;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var service = CreateServiceFromInput();
                services.Add(service);
                AddServiceToListView(service);
                ResetForm();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems.Count > 0 && ValidateInput())
            {
                int index = lstServices.SelectedIndices[0];

                Service existingService = services[index];

                existingService.firstName = txtFirstName.Text;
                existingService.lastName = txtLastName.Text;
                existingService.phoneNumber = txtPhone.Text;
                existingService.Make = cboMake.Text;
                existingService.Model = txtModel.Text;
                existingService.Year = (int)numYear.Value;
                existingService.Colour = txtColour.Text;
                existingService.EngOilChange = chkEngineOil.Checked;
                existingService.TransOilChange = chkTransmission.Checked;
                existingService.AirFilterChange = chkAirFilter.Checked;
                existingService.Price = decimal.Parse(txtCost.Text.Trim('$'));

                UpdateListView();
                ResetForm();
            }
            else if (lstServices.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a service to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems.Count > 0)
            {
                int index = lstServices.SelectedIndices[0];
                services.RemoveAt(index);
                UpdateListView();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please select a service to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (services.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove all services?",
                    "Confirm Remove All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    services.Clear();
                    UpdateListView();
                    ResetForm();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ResetForm();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            numYear.Minimum = currentYear - 20;
            numYear.Maximum = currentYear;
            numYear.Value = currentYear;

            // Setup car makes combo box
            cboMake.Items.AddRange(new string[] {
                "Aston Martin", "Audi", "BMW", "Bentley", "Cadilac", "Chevrolet",
                "Dodge", "Eagle", "Ferrari", "Fiat", "Ford",
                "GMC", "Genesis", "Geo", "Honda", "Hummer", "Hyundai",
                "Infinity", "Isuzu", "Jaguar", "Lamborghini", "Land Rover",
                "Lotus", "Mazda", "Maserati", "Maybach", "McLaren",
                "Mercedez Benz", "Mercury", "Mini", "Mitsubishi",
                "Nissan", "Porsche", "Rolls Royce",
                "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"
            });

            // Add event handlers for checkboxes
            chkEngineOil.CheckedChanged += ServiceCheckBox_CheckedChanged;
            chkTransmission.CheckedChanged += ServiceCheckBox_CheckedChanged;
            chkAirFilter.CheckedChanged += ServiceCheckBox_CheckedChanged;

            // Setup tooltips
            var toolTip = new ToolTip();
            toolTip.SetToolTip(txtFirstName, "Enter the customer's first name (required)");
            toolTip.SetToolTip(txtLastName, "Enter the customer's last name (required)");
            toolTip.SetToolTip(txtPhone, "Enter the customer's phone number (required)");
            toolTip.SetToolTip(cboMake, "Select the vehicle manufacturer from the list");
            toolTip.SetToolTip(txtModel, "Enter the vehicle model name (required)");
            toolTip.SetToolTip(numYear, "Select the vehicle manufacturing year (last 20 years only)");
            toolTip.SetToolTip(txtColour, "Enter the vehicle color (required)");
            toolTip.SetToolTip(chkEngineOil, "Engine oil change service - $60 plus tax");
            toolTip.SetToolTip(chkTransmission, "Transmission oil change service - $120 plus tax");
            toolTip.SetToolTip(chkAirFilter, "Air filter change service - $40.50 plus tax");
            toolTip.SetToolTip(txtCost, "Total cost including 13% tax");

            // Add tooltips for buttons
            toolTip.SetToolTip(btnAdd, "Add a new service record (Alt+A)");
            toolTip.SetToolTip(btnNew, "Clear the form (Alt+N)");
            toolTip.SetToolTip(btnUpdate, "Update selected service record (Alt+U)");
            toolTip.SetToolTip(btnRemove, "Remove selected service record (Alt+R)");
            toolTip.SetToolTip(btnRemoveAll, "Remove all service records (Alt+M)");
            toolTip.SetToolTip(btnExit, "Exit the application (Alt+E)");
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems.Count > 0)
            {
                var service = services[lstServices.SelectedIndices[0]];
                PopulateFormFromService(service);
            }
        }
    }
}
