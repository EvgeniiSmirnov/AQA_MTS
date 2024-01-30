namespace Homework12;

// переопределям атрибут своими значениями из emum Severity
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class SeverityAttribute(Severity level) : PropertyAttribute(level.ToString());