public partial class CountCharactersPage : ContentPage 

{ 

    public CountCharactersPage() 

    { 

        InitializeComponent(); 

    } 

  

    private void OnTextChanged(object sender, TextChangedEventArgs e) 

    { 

        string input = InputEditor.Text; 

  

        int totalCount = input.Length; 

        TotalCount.Text = $"Total de caracteres: {totalCount}"; 

  

        int numberCount = input.Count(char.IsDigit); 

        NumberCount.Text = $"Números: {numberCount}"; 

  

        int letterCount = input.Count(char.IsLetter); 

        LetterCount.Text = $"Letras: {letterCount}"; 

  

        int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c)); 

        VowelCount.Text = $"Vocales: {vowelCount}"; 

  

        int upperCaseCount = input.Count(char.IsUpper); 

        UpperCaseCount.Text = $"Mayúsculas: {upperCaseCount}"; 

  

        int lowerCaseCount = input.Count(char.IsLower); 

        LowerCaseCount.Text = $"Minúsculas: {lowerCaseCount}"; 

    } 

  

    private void OnClearButtonClicked(object sender, EventArgs e) 

    { 

        InputEditor.Text = string.Empty; 

  

        TotalCount.Text = "Total de caracteres: 0"; 

        NumberCount.Text = "Números: 0"; 

        LetterCount.Text = "Letras: 0";  

        VowelCount.Text = "Vocales: 0"; 

        UpperCaseCount.Text = "Mayúsculas: 0"; 

        LowerCaseCount.Text = "Minúsculas: 0"; 

    } 

} 

 

 

 
